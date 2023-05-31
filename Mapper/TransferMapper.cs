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
    public class TransferMapper
    {
        MySqlDataAdapter adapter;

        MySqlDataReader reader;

        DataSet ds;

        MySqlConnection conn;

        MySqlCommand comm;

        DataSource dataSource = new DataSource();

        string sql;

        R r;

        public R insertUtoOtoA(TransferEntity transfer)
        {
            r = new R();
            MySqlTransaction transaction = null;
            try
            {
                conn = dataSource.getConnection();
                transaction = conn.BeginTransaction();
                sql = "insert into transfer(t_id, t_plaintiff_id, t_object_id, t_amount, t_time, t_state)" +
                    "values(@id,@plaintiff, @object, @amount, @time, @state)";
                comm = new MySqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", transfer.T_id);
                comm.Parameters.AddWithValue("state", transfer.T_state);
                comm.Parameters.AddWithValue("plaintiff", transfer.T_plaintiff_id);
                comm.Parameters.AddWithValue("object", transfer.T_object_id);
                comm.Parameters.AddWithValue("time", transfer.T_time);
                comm.Parameters.AddWithValue("amount", transfer.T_amount);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
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
                if (n > 0)
                {
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
