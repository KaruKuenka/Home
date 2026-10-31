using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Home.Main_Page.Helper;

namespace Home
{
    //internal class Data
    //{
    //}
    public static class Db
    {
        private static string ConnStr =>
            ConfigurationManager.ConnectionStrings["HOADB"].ConnectionString;

        public static DataTable Table(string sql, params SqlParameter[] p)
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                da.SelectCommand.Parameters.AddRange(p);
                var t = new DataTable();
                da.Fill(t);
                return t;
            }
        }

        public static int Run(string sql, params SqlParameter[] p)       // INSERT / UPDATE / DELETE
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(p);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] p) // one value
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(p);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static void Log(string action) =>
            Run("INSERT INTO ActivityLog (Username, Role, Action) VALUES (@u, @r, @a)",
                new SqlParameter("@u", Session.Username),
                new SqlParameter("@r", Session.Role),
                new SqlParameter("@a", action));
    }

}
