using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class FindMemberDetailsForm
    {
        public FindMemberDetailsForm()
        {
            Console.WriteLine("Enter Member First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Member Last Name");
            string lastName = Console.ReadLine();

            Member member = new Member(firstName, lastName);

            Program.toolLibrarySystem.findMemberDetails(firstName, lastName);
        }
    }
}
