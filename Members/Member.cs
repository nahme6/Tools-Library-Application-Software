using System;
using System.Collections.Generic;

namespace Tools_Library_Application_Software
{
    public class Member : iMember, IComparable<Member>
    {
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string pin;
        ToolCollection memberTools = new ToolCollection(2);

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.pin = pin;
        }

        public Member(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }

        public string[] Tools
        {
            get
            {
                string[] Tools = Array.ConvertAll<Tool, string>(memberTools.toArray(), ToolCollectionToString);
                return Tools;
            }
        }

        public void GetMemberTools()
        {
            foreach (Tool tool in memberTools.toArray())
            {
                if (tool != null)
                {
                    Console.WriteLine(tool.ToString());
                }
            }
        }

        // fix null tool
        public bool isBorrowingTool(Tool tool)
        {
            foreach (Tool tool1 in memberTools.toArray())
            {
                if (tool1.Name == tool.Name)
                {
                    return true;
                }
            }
            return false;
        }

        // https://stackoverflow.com/questions/15318946/converting-a-object-array-to-an-string-array-in-c
        string ToolCollectionToString(Tool tool)
        {
            return tool?.ToString() ?? string.Empty;
        }

        public void addTool(Tool aTool)
        {
            memberTools.add(aTool);
        }

        public void deleteTool(Tool aTool)
        {
            if (memberTools.search(aTool) == false)
            {
                Console.WriteLine("Member does not have tool");
            } else
            {
                memberTools.delete(aTool);
            }
        }

        public int CompareTo(Member another)
        {
            if (lastName.CompareTo(another.LastName) < 0)
                return -1;
            else
                if (lastName.CompareTo(another.LastName) == 0)
                return firstName.CompareTo(another.FirstName);
            else
                return 1;
        }

        public override string ToString()
        {
            return "First Name: " + firstName + "\n" +
                "Last Name: " + lastName + "\n" +
                "Contact Number: " + contactNumber + "\n";
        }
    }
}
