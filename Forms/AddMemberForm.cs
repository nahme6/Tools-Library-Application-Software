using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class AddMemberForm
    {
        public AddMemberForm()
        {
            Console.WriteLine("Enter New Member First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter New Member Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter New Member Contact Number: ");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter New Member Pin: ");
            string pin = Console.ReadLine();

            Member newMember = new Member(firstName, lastName, contactNumber, pin);

            if (Program.toolLibrarySystem.Members.search(newMember))
            {
                Console.WriteLine("Member Already in System");
                Console.WriteLine();
            } else
            {
                Program.toolLibrarySystem.add(newMember);
                Console.WriteLine("Member Added to System\n");
            }
        }
        public static int validationInt()
        {
            int output;
            bool okayInput = false;
            do
            {
                string toolQuantity = Console.ReadLine();
                okayInput = int.TryParse(toolQuantity, out output);
                if (!okayInput)
                {
                    okayInput = false;
                    Console.WriteLine("You did not enter a correct option.\n\n Please try again");
                    Console.WriteLine("Enter Tool Quantity:");
                }
            } while (!okayInput);
            return output;
        }
    }
}
