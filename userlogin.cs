using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class userlogin
    {
        static string Users;
        public static string user
        {
            get
            {
                return Users;
            }
            set
            {
                Users = value;
            }
        }
    }
}
