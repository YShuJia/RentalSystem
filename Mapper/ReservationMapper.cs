using MySql.Data.MySqlClient;
using RentalSystem.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        string sql;

        R r;

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
    }
}
