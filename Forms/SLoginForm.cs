using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class SLoginForm
    {
        public SLoginForm()
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            if (username == "staff" && password == "today123")
            {
                Console.WriteLine("Access Granted\n");
                new StaffMenu();
            }
            else
            {
                Console.WriteLine("Access Denied\n");
                new MainMenu();
            }
        }
    }
}
