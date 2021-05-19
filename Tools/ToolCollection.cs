using System;
using System.Linq;
namespace Tools_Library_Application_Software
{
    public class ToolCollection : iToolCollection
    {
        private Tool[] toolCollection;
        private int capacity;
        private int count = 0;

        public ToolCollection(int capacity)
        {
           this.capacity = capacity;
           toolCollection = new Tool[capacity];
        }
        public int Number => count;

        public void add(Tool aTool)
        {
            if (count == 0)
            {
                toolCollection[count] = aTool;
                count++;
            }
            else if (!toolCollection.Contains(aTool))
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

        public void writeToolsToConsole()
        {
            foreach (Tool tool in toolCollection.ToArray())
            {
                if (tool != null)
                {
                    Console.WriteLine(tool.ToString());
                }
            }
        }
    }
}       
