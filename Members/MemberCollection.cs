using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class MemberCollection : iMemberCollection
    {
        // Collection needs to be Binary Search Tree
        BSTree memberCollection;
        public MemberCollection()
        {
            memberCollection = new BSTree();
        }
        public int Number => memberCollection.number();

        public void add(Member aMember)
        {
            if (!memberCollection.Search(aMember))
            {
                memberCollection.Insert(aMember);
            } else
            {
                Console.WriteLine("Member Already Exists");
            }
        }

        public void delete(Member aMember)
        {
            if (!memberCollection.Search(aMember))
            {
                Console.WriteLine("Member Doesn't Exist");
            } else
            {
                memberCollection.Delete(aMember);
            }
        }

        public bool search(Member aMember)
        {
           return memberCollection.Search(aMember);
        }

        public Member[] toArray()
        {
           return memberCollection.GetMembers().ToArray();
        }

        public Member GetMember(Member member)
        {
            return memberCollection.GetMember(member);
        }
    }
}
