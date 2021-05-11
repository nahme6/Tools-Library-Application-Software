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
        public int Number => throw new NotImplementedException();

        public void add(Member aMember)
        {
            memberCollection.Insert(aMember);
        }

        public void delete(Member aMember)
        {
            memberCollection.Delete(aMember);
        }

        public bool search(Member aMember)
        {
           return memberCollection.Search(aMember);
        }

        Member[] iMemberCollection.toArray()
        {
            throw new NotImplementedException();
        }
    }
}
