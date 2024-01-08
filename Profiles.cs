using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formProject
{
    public class Profiles
    {
        public List<Profile> s = new List<Profile>();
        public Profiles() 
        {
            s.Add(new Profile("user", "user", 0));
            s.Add(new Profile("admin", "admin", 1));
            s.Add(new Profile("driver", "driver", 2));
        }
    }

    public class Profile
    {
        public string username;
        public string password;
        public int type;

        public Profile(string username, string password, int type)
        {
            this.username = username;
            this.password = password;
            this.type = type; // User, Admin, Driver, Fail
        }
        public Profile(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.type = 0; // User, Admin, Driver, Fail
        }
        public Profile(){}
    }
}
