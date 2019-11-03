using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHQT
{
    class users
    {
        private string user_name;
        private int user_level;
        public users()
        {

        }
        public users(string username, int userlogin)
        {
            user_name = username;
            user_level = userlogin;
        }

        public string getUsername()
        {
            return this.user_name;
        }
        public int getLevel()
        {
            return this.user_level;
        }
    }
}
