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
    public class BillMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        HouseMapper houseMapper;

        string sql;

        R r;

        public R selectByView(int state, string id)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select b_id 订单ID, h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_addr 地址, b_rent '租金(元)',DATEDIFF(b_stop_time,b_start_time) '时长(天)', b_remark 备注 " +
                    "from bill_log where b_state = @state and u_id=@id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state",state);
                comm.Parameters.AddWithValue("id",id);
                adapter = new MySqlDataAdapter(comm);
                ds = new DataSet();
                adapter.Fill(ds);

                r.IsOK = true;
                if (ds.Tables[0].Rows.Count < 1)
                {
                    r.IsOK= false;
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
            finally { 
                conn.Close();
            }
        }

        public R updateState(int state, string b_id, long h_id)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "update bill set b_state = @state where b_id = @b_id and h_id=@h_id";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("b_id", b_id);
                comm.Parameters.AddWithValue("h_id", h_id);
                int n = comm.ExecuteNonQuery();
                if (n>0)
                {
                    houseMapper = new HouseMapper();
                    r = houseMapper.updateState(0, h_id, conn);
                    if(r.IsOK)
                    {
                        transaction.Commit();
                        r.IsOK = true;
                        r.Msg = "操作成功...";
                    }
                }
                else
                {
                    r.IsOK = false;
                    r.Msg = "操作失败...";
                    transaction.Rollback(); 
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
