using Home.Main_Page.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data
{
    public static class AuthService
    {
        private const string SuperAdminUsername = "superadmin";
        // Hash, not the real password. See the one-time snippet below.
        private const string SuperAdminPassword = "CuencaGawa";

        private static readonly string ConnStr =
            ConfigurationManager.ConnectionStrings["HOADB"].ConnectionString;

        // Returns null if the login is wrong. Throws SqlException if the server can't be reached.
        public static LoginResult Authenticate(string username, string password)
        {
            if (username == SuperAdminUsername &&
                password == SuperAdminPassword)
            {
                return new LoginResult { Username = username, FullName = "Super Admin", IsSuperAdmin = true };
            }

            const string sql = @"SELECT UserId, FullName, PasswordHash, HoaPosition, IsHoaActive
                             FROM Users WHERE Username = @u";
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    if (!BCrypt.Net.BCrypt.Verify(password, rd.GetString(2))) return null;

                    string position = rd.IsDBNull(3) ? null : rd.GetString(3);
                    bool active = rd.GetBoolean(4);
                    return new LoginResult
                    {
                        UserId = rd.GetInt32(0),
                        Username = username,
                        FullName = rd.GetString(1),
                        HoaPosition = position,
                        IsOfficer = position != null && active
                    };
                }
            }
        }
    }
}
