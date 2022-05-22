using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class UserAccountInfo
    {
        public string platform, username, password, extraInfo;
        public int id;

        public UserAccountInfo(string platform, string username, string password, string extraInfo = null, int id = 0)
        {
            this.platform = platform;
            this.username = username;
            this.password = password;
            this.id = id;
            this.extraInfo = extraInfo;
        }

        public override string ToString()
        {
            return platform + ' ' + username + ' ' + password  + ' ' + extraInfo + ' ' + id;
        }
    }
}
