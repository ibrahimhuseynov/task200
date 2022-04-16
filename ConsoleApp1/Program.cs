using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("azad", "huseyn1", "hesen", "m12");
            User user1 = new User();
            string user;
            do
            {
                Console.WriteLine("UserName daxil edin :");
                user = Console.ReadLine();
            } while (user.Length < 6);
            user1.UserName = user;
            string userpasword;
            do
            {
                Console.WriteLine("userpasportunuzu daxil edin :");
                userpasword = Console.ReadLine();
            } while (user1.ChekPassword(userpasword) != userpasword);
            user1.Password= userpasword;    
            Console.WriteLine("Isadmini daxil edin");
            admin.IsSuperAdmin = Console.ReadLine();
            Console.WriteLine("Selection daxil edin");
            admin.Selection = Console.ReadLine();
            Console.WriteLine(user1.UserName);
            Console.WriteLine("UserName :" + user1.UserName);
            Console.WriteLine("Password :"+user1.Password);
            Console.WriteLine("IsSuperAdmin :" + admin.IsSuperAdmin);
            Console.WriteLine("Selection :" + admin.Selection);
            Console.ReadLine();
        }
       
    }
}

