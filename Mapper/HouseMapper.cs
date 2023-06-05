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

        public R updateStateToRental(int state, long h_id)
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
                r.Msg = r.IsOK? "操作成功..." : "操作失败...";
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

        public R selectByView(Page page, string o_id, string type, decimal rent, decimal area)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select h_id 房屋ID, h_type 房型, h_area '面积(m²)', h_rent '租金(元)', h_deposit '押金(元)', h_addr 地址, h_introduce 简介," +
                    " h_state '1预约 2租赁 -1下架' from owner_house where o_id=@id";
                if (type != "")
                    sql += " and h_type like @type";
                if (rent != 0)
                    sql += " and h_rent like @rent";
                if (area != 0)
                    sql += " and h_area like @area";

                sql += " limit @pageStart,@pageSize";

                comm = new MySqlCommand(sql, conn);
                
                if (type != "")
                    comm.Parameters.AddWithValue("type", "%" + type + "%");
                if (rent != 0)
                    comm.Parameters.AddWithValue("rent", "%" + rent + "%");
                if (area != 0)
                    comm.Parameters.AddWithValue("area", "%" + area + "%");
                
                comm.Parameters.AddWithValue("id", o_id);
                comm.Parameters.AddWithValue("pageStart", (page.PageNum - 1) * page.PageSize);
                comm.Parameters.AddWithValue("pageSize", page.PageSize);

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

        public R selectByView(Page page, int state, string type, decimal rent, decimal area)
        {
            r = new R();
            try
            {
                conn = dataSource.getConnection();
                sql = "select h_id 房屋ID, o_tel 房主电话, o_sex 性别, h_type 房型, h_area '面积(m²)', h_rent '租金(元)', h_deposit '押金(元)', h_addr 地址, h_introduce 简介" +
                    " from owner_house where h_state = @state ";

                if(type!="")
                    sql += " and h_type like @type";
                if (rent != 0)
                    sql += " and h_rent like @rent";
                if (area != 0)
                    sql += " and h_area like @area";

                sql += " limit @pageStart,@pageSize";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("state", state);
                comm.Parameters.AddWithValue("pageStart", (page.PageNum - 1) * page.PageSize);
                comm.Parameters.AddWithValue("pageSize", page.PageSize);

                if (type != "")
                    comm.Parameters.AddWithValue("type", "%"+type+"%");
                if (rent != 0)
                    comm.Parameters.AddWithValue("rent", "%" + rent + "%");
                if (area != 0)
                    comm.Parameters.AddWithValue("area", "%" + area + "%");

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
