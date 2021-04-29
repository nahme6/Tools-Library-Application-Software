using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class Member : iMember
    {
        string firstName;
        string lastName;
        string contactNumber;
        string pin;
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

        public string[] Tools => ToolCollection.toArray();

        public void addTool(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(iTool aTool)
        {
            throw new NotImplementedException();
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
    }
}
