using MySql.Data.MySqlClient;
using RentalSystem.Common;
using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem.Mapper
{
    public class OwnerMapper
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
                sql = "select o_id, o_pass, o_name, o_tel, o_sex, o_point, o_account, o_state from owner where o_id=@id and o_pass=@pass";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass", pass);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    int state = Convert.ToInt32(reader["o_state"]);
                    if (state == 1)
                    {
                        r.Msg = "该房主已冻结...";
                        return r;
                    }
                    else if (state == 2)
                    {
                        r.Msg = "该房主已注销...";
                        return r;
                    }
                    OwnerEntity owner = new OwnerEntity();
                    owner.O_id = reader["o_id"].ToString();
                    owner.O_tel = reader["o_tel"].ToString();
                    owner.O_name = reader["o_name"].ToString();
                    owner.O_pass = reader["o_pass"].ToString();
                    owner.O_point = Convert.ToInt32(reader["o_point"]);
                    owner.O_sex = reader["o_sex"].ToString();
                    owner.O_account = Convert.ToDecimal(reader["o_account"]);

                    r.IsOK = true;
                    r.Obj = owner;
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

        public R register(OwnerEntity owner)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "insert into owner(o_id,o_pass,o_tel,o_name)values(@id,@pass,@tel,@name)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", owner.O_id);
                comm.Parameters.AddWithValue("pass", owner.O_pass);
                comm.Parameters.AddWithValue("tel", owner.O_tel);
                comm.Parameters.AddWithValue("name", owner.O_name);
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

        public bool updateAccountById(string id, decimal amount, bool isInOut, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update owner set o_account=o_account+@amount where o_id=@id";
                if (!isInOut)
                {
                    sql = "update owner set o_account=o_account-@amount where o_id=@id";
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

        public R updateOwnerById(OwnerEntity owner)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update owner set o_name=@name, o_tel=@tel, o_sex=@sex where o_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", owner.O_id);
                comm.Parameters.AddWithValue("tel", owner.O_tel);
                comm.Parameters.AddWithValue("sex", owner.O_sex);
                comm.Parameters.AddWithValue("name", owner.O_name);
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
                r.IsOK = false;
                r.Msg = "服务器异常...";
            }
            finally
            {
                conn.Close();
            }
            return r;
        }

        public R updatePassById(string id, string pass)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update owner set o_pass=@pass where o_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                comm.Parameters.AddWithValue("pass", pass);
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
                r.IsOK = false;
                r.Msg = "服务器异常...";
            }
            finally
            {
                conn.Close();
            }
            return r;
        }

        public bool updateAccountById(string id, decimal amount, bool isInOut, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update owner set o_account=o_account+@amount where o_id=@id";
                if (!isInOut)
                {
                    sql = "update owner set o_account=o_account-@amount where o_id=@id";
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
    }
}
