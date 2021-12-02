using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryManager
{
    static class LoginFlag
    {
        static bool loginFlag;
        static string userId;
        static public string flagUserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        static public bool flagUserBool
        {
            get
            {
                return loginFlag;
            }
            set
            {
                loginFlag = value;
            }
        }
    }
}
