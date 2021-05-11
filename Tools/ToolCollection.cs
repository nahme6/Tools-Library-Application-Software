using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Tools_Library_Application_Software
{
    class ToolCollection : iToolCollection
    {
        // Check whether this has to be explicitly an array data structure
        private Tool[] toolCollection;
        private int capacity;
        private int count;

        public ToolCollection(int capacity, int count)
        {
           this.capacity = capacity;
           this.count = count;
           toolCollection = new Tool[capacity];

        }
        public int Number => capacity;

        public void add(Tool aTool)
        {
            if (count == 0)
            {
                toolCollection[count] = aTool;
                count++;
            }
            else if (!toolCollection.Contains(aTool) && count < capacity)
            {
                toolCollection[count] = aTool;
                count++;
            }
            else
            {
                Console.WriteLine("Tool already exsists in the system");
            }
        }

        public void delete(Tool aTool)
        {
            Tool deleteTool = aTool;

            for (int i = 0; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (string.Compare(toolCollection[i].Name, deleteTool.Name) == 0)
                    {
                        toolCollection[i] = toolCollection[j];
                        count--;
                    }
                }
            }
        }

        public bool search(Tool aTool)
        {
            bool toolSearch = false;
            foreach (Tool tool in toolCollection)
            {
                if (tool == aTool)
                {
                    toolSearch = true;
                }
            }
            return toolSearch;
        }

        public Tool[] toArray()
        {
            return toolCollection.ToArray();
        }
    }
}
