using MySql.Data.MySqlClient;
using RentalSystem.Common;
using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace RentalSystem.Mapper
{
    public class BillMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        HouseMapper houseMapper= new HouseMapper();

        string sql;

        R r;


        public R insert(BillEntity bill)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "insert into bill(b_id, h_id, u_id, b_day, b_rent,b_premium,b_deposit,b_state) " +
                    " values(@b_id, @h_id, @u_id, @day, @b_rent,@b_premium,@b_deposit,@b_state)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("b_id", bill.B_id);
                comm.Parameters.AddWithValue("h_id", bill.H_id);
                comm.Parameters.AddWithValue("u_id", bill.U_id);
                comm.Parameters.AddWithValue("day", bill.B_day);
                comm.Parameters.AddWithValue("b_rent", bill.B_rent);
                comm.Parameters.AddWithValue("b_premium", bill.B_premium);
                comm.Parameters.AddWithValue("b_deposit", bill.B_deposit);
                comm.Parameters.AddWithValue("b_state", bill.B_state);
                int n = comm.ExecuteNonQuery();
                houseMapper = new HouseMapper();

                r.IsOK = n > 0 && houseMapper.updateState(2, bill.H_id, conn).IsOK;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                if (r.IsOK)
                    transaction.Commit();
                else
                    transaction.Rollback();
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

        public R selectByView(int state, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select b_id 订单ID, h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_addr 地址, b_rent '租金(元)', b_deposit '押金(元)',b_day '时长(天)'" +
                    " from bill_log where b_state = @state and u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state",state);
                comm.Parameters.AddWithValue("id",id);
                adapter = new MySqlDataAdapter(comm);
                ds = new DataSet();
                adapter.Fill(ds);
                r.IsOK = ds.Tables[0].Rows.Count > 0;
                r.Msg = r.IsOK ? "" : "暂无数据...";
                r.Obj = ds;
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "暂无数据...";
                return r;
            }
            finally { 
                conn.Close();
            }
        }

        public R selectByView(int state1, int state2, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select b_id 订单ID, h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_addr 地址, b_rent '租金(元)', b_deposit '押金(元)',b_day '时长(天)'" +
                    " from bill_log where b_state = @state1 or b_state=@state2 and u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state1", state1);
                comm.Parameters.AddWithValue("state2", state2);
                comm.Parameters.AddWithValue("id", id);
                adapter = new MySqlDataAdapter(comm);
                ds = new DataSet();
                adapter.Fill(ds);
                r.IsOK = ds.Tables[0].Rows.Count > 0;
                r.Msg = r.IsOK ? "" : "暂无数据...";
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

        public R selectByTable(int state, string o_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "SELECT b_id 订单ID, u_id 用户ID, u_tel 用户电话, u_sex 性别, h_id 房屋ID, h_addr 房屋地址, b_rent '租金(元)', b_deposit '押金(元)', b_premium 手续费, b_day '租期(天)' " +
                    "FROM bill JOIN house USING(h_id) JOIN users USING(u_id) WHERE h_id IN( " +
                    "SELECT h_id FROM house WHERE o_id in (" +
                    "SELECT o_id FROM `owner`) and o_id = @id ) and b_state = @state";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("id", o_id);
                adapter = new MySqlDataAdapter(comm);
                ds = new DataSet();
                adapter.Fill(ds);
                r.IsOK = ds.Tables[0].Rows.Count > 0;
                r.Msg = r.IsOK ? "" : "暂无数据...";
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

        public decimal selectPremiumByView(string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select b_premium from bill_log where b_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToDecimal(reader["b_premium"]);
                }
            }
            catch (Exception ex)
            {
                r.Msg = "暂无数据...";
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public R updateState(string b_id, int b_state, long h_id, int h_state)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "update bill set b_state = @state where b_id = @b_id and h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();

                r.IsOK = n > 0 && houseMapper.updateState(h_state, h_id, conn).IsOK;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                if (r.IsOK)
                    transaction.Commit();
                else
                    transaction.Rollback();
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

        public R updateState(string b_id, int b_state, long h_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update bill set b_state = @state where b_id = @b_id and h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
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

        public R updateState(string b_id, int b_state, string u_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update bill set b_state = @state where b_id = @b_id and u_id=@u_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("u_id", u_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
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

        public R updateState(string b_id, int b_state, long h_id, int h_state, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update bill set b_state = @state where b_id = @b_id and h_id=@h_id";
                comm = new MySqlCommand(sql, con);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                houseMapper = new HouseMapper();
                r.IsOK = n > 0&& houseMapper.updateState(h_state, h_id, con).IsOK;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                return r;
            }
        }

        public R updateStopTime(string b_id, long h_id, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "UPDATE bill SET b_stop_time = DATE_ADD(NOW(),INTERVAL b_day DAY) WHERE b_id = @b_id and h_id=@h_id";
                comm = new MySqlCommand(sql, con);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "操作失败...";
                return r;
            }
        }
    }
}
