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

        public R selectByTable(Page page, string sex, string tel, int point)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select u_id 用户ID, u_name 姓名, u_tel 电话, u_sex 性别, u_point 积分, u_state '0在线 1冻结 -1注销' from users where 1=1";

                if (sex != "")
                    sql += " and u_sex like @sex";
                if (tel != "")
                    sql += " and u_tel like @tel";
                if (point != -1000)
                    sql += " and u_point like @point";

                sql += " limit @pageStart,@pageSize";

                comm = new MySqlCommand(sql, conn);
                if (sex != "")
                    comm.Parameters.AddWithValue("sex", "%" + sex + "%");
                if (tel != "")
                    comm.Parameters.AddWithValue("tel", "%" + tel + "%");
                if (point != -1000)
                    comm.Parameters.AddWithValue("point", "%" + point + "%");

                comm.Parameters.AddWithValue("pageStart", (page.PageNum - 1) * page.PageSize);
                comm.Parameters.AddWithValue("pageSize", page.PageSize);

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
                r.Msg = "服务器异常...";
                return r;
            }
            finally
            {
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
                r.IsOK = n > 0;
                r.Msg = r.IsOK ? "注册成功，请返回登录..." : "注册失败，请检查后重试...";
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

        public bool updateAccountById(string id, decimal amount, bool isIn, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update users set u_account=u_account+@amount where u_id=@id";
                if (!isIn)
                {
                    sql = "update users set u_account=u_account-@amount where u_id=@id";
                }
                comm = new MySqlCommand(sql, con);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("amount", amount);
                int n = comm.ExecuteNonQuery();
                return n>0;
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
                sql = "update users set u_pass=@pass where u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass",pass);
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

        public R updateUser(UserEntity user)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update users set u_name=@name, u_tel=@tel, u_sex=@sex, u_addr=@addr where u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", user.U_id);
                comm.Parameters.AddWithValue("tel", user.U_tel);
                comm.Parameters.AddWithValue("sex", user.U_sex);
                comm.Parameters.AddWithValue("addr", user.U_addr);
                comm.Parameters.AddWithValue("name", user.U_name);
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

        public R updateStateById(string id, int state)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update users set u_state=@state where u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("state", state);
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
        public R updatePointById(string id, int total_point)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update users set u_point=@point where u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("point", total_point);
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

        public R updatePointById(string id, int change_point, bool add)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update users set u_point=u_point-@point where u_id=@id";
                if (add)
                {
                    sql = "update users set u_point=u_point+@point where u_id=@id";
                }
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("point", change_point);
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
