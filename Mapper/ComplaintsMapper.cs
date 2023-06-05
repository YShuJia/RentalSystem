using MySql.Data.MySqlClient;
using RentalSystem.Common;
using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentalSystem.Mapper
{
    public class ComplaintsMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        string sql;

        R r;

        public R insert(ComplaintsEntity complaints)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "insert into complaints(c_id, c_plaintiff, c_type , c_time, c_content, c_something, c_schedule, c_result)" +
                    "values(@c_id, @c_plaintiff, @c_type , @c_time, @c_content, @c_something, @c_schedule, @c_result)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("c_something", complaints.C_something);
                comm.Parameters.AddWithValue("c_schedule", complaints.C_schedule);
                comm.Parameters.AddWithValue("c_type", complaints.C_type);
                comm.Parameters.AddWithValue("c_plaintiff", complaints.C_plaintiff);
                comm.Parameters.AddWithValue("c_content", complaints.C_content);
                comm.Parameters.AddWithValue("c_time", complaints.C_time);
                comm.Parameters.AddWithValue("c_id", complaints.C_id);
                comm.Parameters.AddWithValue("c_result", complaints.C_result);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
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

        public R selectByTable(string id, int state, int schedule)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();

                sql = "select c_id 投诉ID, c_plaintiff 投诉人, c_something 被投诉人, c_type 投诉人身份, c_time 时间, c_content 投诉内容, c_result 协商结果 " +
                    "from complaints where (c_plaintiff=@id or c_something=@id) and c_state = @state and c_schedule = @schedule";
                
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("schedule", schedule);
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

        public R selectByTable(int schedule)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select c_id 投诉ID, c_plaintiff 投诉人, c_something 被投诉人, c_type 投诉人身份, c_time 时间, c_content 投诉内容, c_result 协商结果 " +
                    " from complaints where c_state = 0 and c_schedule=@schedule";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("schedule", schedule);
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

        public R updateComplaints(ComplaintsEntity complaints)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update complaints set c_result=@result, c_state=@state " +
                    "where c_id=@id and c_time=@time and c_plaintiff=@plaintiff";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("result", complaints.C_result);
                comm.Parameters.AddWithValue("plaintiff", complaints.C_plaintiff);
                comm.Parameters.AddWithValue("time", complaints.C_time);
                comm.Parameters.AddWithValue("state", complaints.C_state);
                comm.Parameters.AddWithValue("id", complaints.C_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                r.IsOK = false;
                r.Msg = "服务器异常...";
            }
            finally
            {
                conn.Close();
            }
            return r;
        }

        public R updateR_S_S(ComplaintsEntity complaints)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update complaints set c_result=@result, c_schedule=@schedule, c_state=@state " +
                    " where c_id=@id and c_time=@time and c_plaintiff=@plaintiff ";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("result", complaints.C_result);
                comm.Parameters.AddWithValue("schedule", complaints.C_schedule);
                comm.Parameters.AddWithValue("plaintiff", complaints.C_plaintiff);
                comm.Parameters.AddWithValue("time", complaints.C_time);
                comm.Parameters.AddWithValue("id", complaints.C_id);
                comm.Parameters.AddWithValue("state", complaints.C_state);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                r.IsOK = false;
                r.Msg = "服务器异常...";
            }
            finally
            {
                conn.Close();
            }
            return r;
        }
    }
}
