using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banking
{ 
        public static class UserSession
        {
            public static int UserID { get; set; }
            public static string Username { get; set; }
            public static string FullName { get; set; }
            public static string Role { get; set; }

            public static void Clear()
            {
                UserID = 0;
                Username = string.Empty;
                FullName = string.Empty;
                Role = string.Empty;
            }
        }
    }

