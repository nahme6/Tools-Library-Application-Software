using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class ToolCollection : iToolCollection
    {
        // Check whether this has to be explicitly an array data structure
        Tool[] toolCollection; 

        public ToolCollection()
        {

        }
        public int Number => throw new NotImplementedException();

        public void add(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public bool search(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public iTool[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
