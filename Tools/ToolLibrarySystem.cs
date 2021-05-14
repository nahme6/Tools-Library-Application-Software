using System;

namespace Tools_Library_Application_Software.Tools
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        public ToolLibrarySystem()
        {
            ToolCollection[][] toolCategories = new ToolCollection[8][];

            /*
            toolCategories[0] = new ToolCollection[4][];
            toolCategories[1] = new ToolCollection[4][];
            toolCategories[2] = new ToolCollection[4];
            toolCategories[3] = new ToolCollection[4];
            toolCategories[4] = new ToolCollection[4];
            toolCategories[5] = new ToolCollection[4];
            toolCategories[6] = new ToolCollection[4];
            toolCategories[7] = new ToolCollection[4];
            toolCategories[8] = new ToolCollection[4];
            */
            //string[] toolCategory = {"Gardening Tools", "Flooring Tools", "Fencing Tools", "Measuring Tools", "Cleaning Tools", "Painting Tools", "Electronic Tools", "Electricity Tools", "Automotive Tools"};
        }
        public void add(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void add(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
