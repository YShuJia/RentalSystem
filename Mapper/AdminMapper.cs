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
    public class AdminMapper
    {

        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        string sql;

        R r;

        public R login(string id, string pass)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select a_id, a_pass, a_account, a_tel from admin where a_id=@id and a_pass=@pass";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass", pass);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    AdminEntity admin = new AdminEntity();
                    admin.A_id = reader["a_id"].ToString();
                    admin.A_pass = reader["a_pass"].ToString();
                    admin.A_tel = reader["a_tel"].ToString();
                    admin.A_account = Convert.ToDecimal(reader["a_account"]);
                    r.IsOK = true;
                    r.Obj = admin;
                }
                else
                {
                    r.Msg = "请检查账号和密码后重试...";
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "服务器异常...";
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        //管理员id为admin
        public bool updateAccountById(string id, decimal amount, bool isInOut, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update admin set a_account=a_account+@amount where a_id=@id";
                if (!isInOut)
                {
                    sql = "update admin set a_account=a_account-@amount where a_id=@id";
                }
                comm = new MySqlCommand(sql, con);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("amount", amount);
                int n = comm.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public R updatePassById(string id, string pass)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update admin set a_pass=@pass where a_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass", pass);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n>0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                return r;
            }
        }

        public R updateAdmin(AdminEntity admin)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update admin set a_tel=@tel where a_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", admin.A_id);
                comm.Parameters.AddWithValue("tel", admin.A_tel);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "操作成功..." : "操作失败...";
                return r;
            }
            catch (Exception ex)
            {
                return r;
            }
        }
    }
}
