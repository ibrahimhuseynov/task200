using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Admin:User
    {
        public string IsSuperAdmin { get; set; }    
        public string Selection { get; set; } 
        public Admin(string username,string passport,string isSuperAdmin,string selection)
        {
            IsSuperAdmin = isSuperAdmin;    
            Selection = selection;
            UserName = username;
            Password = passport;
        }
      
    }
}
