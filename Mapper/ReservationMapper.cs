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
    public class ReservationMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        HouseMapper houseMapper = new HouseMapper();

        string sql;

        R r;

        public R insert(ReservationEntity reservation)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "insert into reservation(r_id, h_id, u_id, r_time,r_state) " +
                    " values(@r_id, @h_id, @u_id, @time, @r_state)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("r_id", reservation.R_id);
                comm.Parameters.AddWithValue("h_id", reservation.H_id);
                comm.Parameters.AddWithValue("u_id", reservation.U_id);
                comm.Parameters.AddWithValue("time", reservation.R_time);
                comm.Parameters.AddWithValue("r_state", reservation.R_state);
                int n = comm.ExecuteNonQuery();
                houseMapper = new HouseMapper();
                r.IsOK = n > 0 && houseMapper.updateState(1, reservation.H_id, conn).IsOK;
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
                sql = "select r_id 预约ID, h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_addr 地址, r_time 预约时间 " +
                    "from reservation_log where r_state = @state and u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
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

        public R selectByView(int state1, int state2, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select r_id 预约ID, h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_addr 地址, r_time 预约时间 " +
                    "from reservation_log where r_state = @state1 or r_state=@state2 and u_id=@id";
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

        public R selectByTable(int state, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "SELECT r_id 预约ID, u_tel 用户电话, u_sex 性别, h_id 房屋ID, h_addr 房屋地址, r_time 预约时间 " +
                    "FROM reservation JOIN house USING(h_id) JOIN users USING(u_id) " +
                    "WHERE h_id IN( SELECT h_id FROM house WHERE o_id in (SELECT o_id FROM `owner`) and o_id = @id ) and r_state = @state";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
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

        public R updateState(string r_id, int r_state, long h_id, int h_state)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "update reservation set r_state = @state where r_id = @r_id and h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", r_state);
                comm.Parameters.AddWithValue("r_id", r_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                houseMapper = new HouseMapper();

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

        public R updateState(string r_id, int b_state, string u_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update reservation set r_state = @state where r_id = @r_id and u_id=@u_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("r_id", r_id);
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

        public R updateState(string r_id, int b_state, long h_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update reservation set r_state = @state where r_id = @r_id and h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", b_state);
                comm.Parameters.AddWithValue("r_id", r_id);
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
    }
}
