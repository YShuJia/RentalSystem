using MySql.Data.MySqlClient;
using RentalSystem.Common;
using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Mapper
{
    public class TransferMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        UserMapper userMapper = new UserMapper();

        OwnerMapper ownerMapper = new OwnerMapper();

        AdminMapper adminMapper = new AdminMapper();

        BillMapper billMapper = new BillMapper();

        string sql;

        R r;

        private MySqlCommand getComm(TransferEntity transfer,MySqlConnection con)
        {
            sql = "insert into transfer(t_id, t_plaintiff_id, t_object_id, t_amount, t_time, t_state)" +
                   "values(@id,@plaintiff, @object, @amount, @time, @state)";
            comm = new MySqlCommand(sql, con);
            comm.Parameters.AddWithValue("id", transfer.T_id);
            comm.Parameters.AddWithValue("state", transfer.T_state);
            comm.Parameters.AddWithValue("plaintiff", transfer.T_plaintiff_id);
            comm.Parameters.AddWithValue("object", transfer.T_object_id);
            comm.Parameters.AddWithValue("time", transfer.T_time);
            comm.Parameters.AddWithValue("amount", transfer.T_amount);

            return comm;
        }

        //同意订单
        public R insertUtoOtoA(TransferEntity uToO, TransferEntity oToA, string b_id, long h_id)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                int n = getComm(uToO,conn).ExecuteNonQuery();
                int m = getComm(oToA,conn).ExecuteNonQuery();
                if (n < 0 || m < 0)
                {
                    r.Msg = "操作失败...";
                    transaction.Rollback();
                    return r;
                }
                //(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0取消
                if (uToO.T_state == 1 &&
                    userMapper.updateAccountById(uToO.T_plaintiff_id, uToO.T_amount, false, conn) &&
                    ownerMapper.updateAccountById(uToO.T_object_id, uToO.T_amount, true, conn) &&
                    ownerMapper.updateAccountById(oToA.T_plaintiff_id, oToA.T_amount, false, conn) &&
                    adminMapper.updateAccountById(oToA.T_object_id, oToA.T_amount, true, conn) &&
                    billMapper.updateState(b_id, 1, h_id, 2, conn).IsOK &&
                    billMapper.updateStopTime(b_id, h_id, conn).IsOK
                    )
                {
                    r.IsOK = true;
                    transaction.Commit();
                    r.Msg = "操作成功...";
                }
                else
                {
                    transaction.Rollback();
                    r.Msg = "余额不足...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                transaction.Rollback();
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public R insertUtoO(TransferEntity transfer, string b_id, long h_id)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                int n = getComm(transfer,conn).ExecuteNonQuery();

                if (n < 0)
                {
                    transaction.Rollback();
                    return r;
                }
                //(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0取消
                if (transfer.T_state == 1 && userMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn) &&
                ownerMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn))
                {
                    r.IsOK = true;
                }
                else if (transfer.T_state == -1 && userMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn) &&
                ownerMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn) && 
                billMapper.updateState(b_id, 3, h_id, 0, conn).IsOK)
                {
                    r.IsOK = true;
                }

                if (r.IsOK)
                {
                    transaction.Commit();
                    r.Msg = "操作成功...";
                }
                else
                {
                    transaction.Rollback();
                    r.Msg = "操作失败...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                transaction.Rollback();
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public R insertOtoA(TransferEntity transfer)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                int n = getComm(transfer, conn).ExecuteNonQuery();

                if (n < 0)
                {
                    transaction.Rollback();
                    return r;
                }
                //(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0取消

                if (transfer.T_state == 2 && ownerMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn) &&
                adminMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn))
                {
                    r.IsOK = true;
                }
                else if (transfer.T_state == -2 && ownerMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn) &&
                adminMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn))
                {
                    r.IsOK = true;
                }

                if (r.IsOK)
                {
                    transaction.Commit();
                    r.Msg = "操作成功...";
                }
                else
                {
                    transaction.Rollback();
                    r.Msg = "操作失败...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                transaction.Rollback();
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public R insertUtoA(TransferEntity transfer)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                int n = getComm(transfer, conn).ExecuteNonQuery();

                if (n < 0)
                {
                    r.IsOK = false;
                    transaction.Rollback();
                    return r;
                }
                //(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0取消

                if (transfer.T_state == 3 && userMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn) &&
                adminMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn))
                {
                    r.IsOK = true;
                }
                else if (transfer.T_state == -3 && userMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, true, conn) &&
                adminMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, false, conn))
                {
                    r.IsOK = true;
                }

                if (r.IsOK)
                {
                    transaction.Commit();
                    r.Msg = "操作成功...";
                }
                else
                {
                    transaction.Rollback();
                    r.Msg = "操作失败...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                transaction.Rollback();
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public R selectByTable(int state, int state1, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                if(state < 0)
                {
                    sql = "select t_id 帐单ID, t_plaintiff_id 转入, t_amount 金额, t_time 时间" +
                    " from transfer where t_state = @state or t_state = @state1 and t_object_id=@id";
                }
                else
                {
                    sql = "select t_id 帐单ID, t_object_id 转向, t_amount 金额, t_time 时间" +
                    " from transfer where t_state = @state or t_state = @state1 and t_plaintiff_id=@id";
                }

                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("state1", state1);
                comm.Parameters.AddWithValue("id", id);
                adapter = new MySqlDataAdapter(comm);
                ds = new DataSet();
                adapter.Fill(ds);

                r.IsOK = true;
                if (ds.Tables[0].Rows.Count < 1)
                {
                    r.IsOK = false;
                    r.Msg = "暂无数据...";
                }
                r.Obj = ds;
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "暂无数据...";
                return r;
            }
            finally
            {
                conn.Close();
            }
        }
        public R updateState(string t_id, int b_state, string t_object_id, string t_plaintiff_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update transfer set t_state = @state where t_id = @t_id and t_object_id=@t_object_id and t_plaintiff_id=@t_plaintiff_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("t_id", t_id);
                comm.Parameters.AddWithValue("t_object_id", t_object_id);
                comm.Parameters.AddWithValue("t_plaintiff_id", t_plaintiff_id);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    r.IsOK = true;
                    r.Msg = "操作成功...";
                }
                else
                {
                    r.IsOK = false;
                    r.Msg = "操作失败...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
