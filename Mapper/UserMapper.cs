using MySql.Data.MySqlClient;
using System.Data;
using RentalSystem.Common;
using System;
using RentalSystem.Entity;

namespace RentalSystem.Mapper
{
    public class UserMapper
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
                sql = "select u_id, u_pass, u_name, u_tel, u_sex, u_addr, u_point, u_account, u_state from users where u_id=@id and u_pass=@pass";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass", pass);
                reader = comm.ExecuteReader();
                if(reader.Read())
                {
                    int state = Convert.ToInt32(reader["u_state"]);
                    if (state == 1)
                    {
                        r.Msg = "该用户已冻结...";
                        return r;
                    }
                    else if(state == 2) 
                    {
                        r.Msg = "该用户已注销...";
                        return r;
                    }
                    UserEntity user = new UserEntity();
                    user.U_id = reader["u_id"].ToString();
                    user.U_tel = reader["u_tel"].ToString();
                    user.U_addr = reader["u_addr"].ToString();
                    user.U_name = reader["u_name"].ToString();
                    user.U_pass = reader["u_pass"].ToString();
                    user.U_point = Convert.ToInt32(reader["u_point"]);
                    user.U_sex = reader["u_sex"].ToString();
                    user.U_account = Convert.ToDecimal(reader["u_account"]);

                    r.IsOK = true;
                    r.Obj = user;
                }
                else
                {
                    r.Msg = "请检查账号和密码后重试...";
                }
                return r;
            }
            catch(Exception ex)
            {
                r.Msg = "服务器异常...";
                return r;
            }
            finally { 
                conn.Close();
            }
        }

        public R register(UserEntity user)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "insert into users(u_id,u_pass,u_tel,u_name)values(@id,@pass,@tel,@name)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", user.U_id);
                comm.Parameters.AddWithValue("pass", user.U_pass);
                comm.Parameters.AddWithValue("tel", user.U_tel);
                comm.Parameters.AddWithValue("name", user.U_name);
                int n = comm.ExecuteNonQuery();
                if (n < 0)
                {
                    r.Msg = "注册失败，请检查后重试...";
                }
                else
                {
                    r.Msg = "注册成功，请返回登录...";
                    r.IsOK = true;
                }
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "该身份证已注册...";
                r.IsOK = false;
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public R s(string id, string tel, string pass)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return r;
        }
    }
}
