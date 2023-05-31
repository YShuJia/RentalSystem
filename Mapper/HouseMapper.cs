using MySql.Data.MySqlClient;
using RentalSystem.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace RentalSystem.Mapper
{
    public class HouseMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        string sql;

        R r;

        public R updateState(int state, long h_id, MySqlConnection con)
        {
            r = new R();
            try
            {
                sql = "update house set h_state = @state where h_id=@h_id";
                comm = new MySqlCommand(sql, con);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n>0;
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "修改失败...";
                return r;
            }
        }

        public R updateState(int state, long h_id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "update house set h_state = @state where h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                r.IsOK = n > 0;
                return r;
            }
            catch (Exception ex)
            {
                r.Msg = "修改失败...";
                return r;
            }
            finally
            {
                conn.Close();
            }
        }

        public String selectO_idByH_id(long id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select o_id from house where h_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return reader["o_id"].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                r.Msg = "暂无数据...";
                return "";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
