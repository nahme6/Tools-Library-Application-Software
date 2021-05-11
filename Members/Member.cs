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
        private ToolCollection memberTools;

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.pin = pin;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }

        public string[] Tools
        {
            get
            {
                string[] Tools = Array.ConvertAll(memberTools.toArray(), new Converter<Tool, string>(ToolToString)); 
                return Tools;
            }
        }

        private string ToolToString(Tool aTool)
        {
            return new string(aTool.Name);
        }

        public void addTool(Tool aTool)
        {
            memberTools.add(aTool);
        }

        public void deleteTool(Tool aTool)
        {
            memberTools.delete(aTool);
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
