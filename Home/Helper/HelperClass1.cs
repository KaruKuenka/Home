using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Main_Page.Helper
{
    public class LoginResult
    {
        public int UserId;
        public string Username;
        public string FullName;
        public string HoaPosition;      // null if not an officer
        public bool IsSuperAdmin;
        public bool IsOfficer;          // has an active HOA position
    }

    public static class Session
    {
        public static int UserId;
        public static string Username;
        public static string FullName;
        public static string Role;      // "HomeOwner", "Admin" or "SuperAdmin"
        public static string HoaPosition;

        public static void Start(LoginResult r, string role)
        {
            UserId = r.UserId; Username = r.Username; FullName = r.FullName;
            HoaPosition = r.HoaPosition; Role = role;
        }

        public static void Clear()
        {
            UserId = 0; Username = FullName = Role = HoaPosition = null;
        }
    }
}
