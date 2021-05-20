using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class MLoginForm
    {
        public Member memberLogin;
        public MLoginForm()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter PIN: ");
            string pin = Console.ReadLine();

            Member member = new Member(firstName, lastName, "0", pin);

            if (Program.toolLibrarySystem.memberLogin(member) == true)
            {
                Console.WriteLine("Access Granted\n");
                memberLogin = Program.toolLibrarySystem.members.GetMember(member);
                new MemberMenu(memberLogin);
            } else
            {
                Console.WriteLine("Access Denied\n");
                new MainMenu();
            }
        }

        public Member GetMember
        {
            get => memberLogin;
        }
    }
}
