using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User ();
            user.Username = "itShain";
            user.Password = "itSh123456";

            Admin admin = new Admin();
            admin.Section = "Section";
            admin.IsSuperAdmin = true;
                    
         }
        
        class Admin 
        {
            public string Section;
            public bool IsSuperAdmin;
        } 

        class User
        {
            public string Username;
            public string Password;

              
                     
        }
        
   
    }
}
