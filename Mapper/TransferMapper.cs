using MySql.Data.MySqlClient;
using RentalSystem.Common;
using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        string sql;

        R r;

        public R insertUtoOtoA(TransferEntity transfer)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "insert into transfer(t_id, t_plaintiff_id, t_object_id, t_amount, t_time, t_state)" +
                    "values(@id,@plaintiff, @object, @amount, @time, @state)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", transfer.T_id);
                comm.Parameters.AddWithValue("state", transfer.T_state);
                comm.Parameters.AddWithValue("plaintiff", transfer.T_plaintiff_id);
                comm.Parameters.AddWithValue("object", transfer.T_object_id);
                comm.Parameters.AddWithValue("time", transfer.T_time);
                comm.Parameters.AddWithValue("amount", transfer.T_amount);
                int n = comm.ExecuteNonQuery();

                if (n<0)
                {
                    r.IsOK = false;
                    transaction.Rollback();
                    return r;
                }
                //(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0取消
                bool isInOut = false;
                string id;
                if(Math.Abs(transfer.T_state) == 1)
                {
                    isInOut = transfer.T_state<0;
                    if (transfer.T_state == 1 && userMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn) &&
                    ownerMapper.updateAccountById(transfer.T_object_id , transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                    else if(transfer.T_state == -1 && userMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, isInOut, conn) &&
                    ownerMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                }
                else if (Math.Abs(transfer.T_state) == 2)
                {
                    isInOut = transfer.T_state < 0;
                    if (transfer.T_state ==2 && ownerMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn) &&
                    adminMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                    else if (transfer.T_state == -2 && ownerMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, isInOut, conn) &&
                    adminMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                }
                else if (Math.Abs(transfer.T_state) == 3)
                {
                    isInOut = transfer.T_state < 0;
                    if (transfer.T_state == 3 && userMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn) &&
                    adminMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                    else if (transfer.T_state == -3 && userMapper.updateAccountById(transfer.T_object_id, transfer.T_amount, isInOut, conn) &&
                    adminMapper.updateAccountById(transfer.T_plaintiff_id, transfer.T_amount, isInOut, conn))
                    {
                        transaction.Commit();
                        r.IsOK = true;
                    }
                }
                else
                {
                    transaction.Rollback();
                    r.IsOK = false;
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

    }
}
