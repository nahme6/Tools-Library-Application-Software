using System;

namespace Tools_Library_Application_Software
{
    public class BorrowToolForm

    {
        public BorrowToolForm(ToolTypes toolTypes)
        {
            Program.toolLibrarySystem.toolCollectionSelection(toolTypes).writeToolsToConsole();

            Console.WriteLine("Enter Tool Name: ");
            Console.WriteLine();
            string toolName = Console.ReadLine();

            Tool newTool = new Tool(toolName);

            for (int i = 1; i < Program.toolLibrarySystem.toolCategories.Length; i++)
            {
                for (int j = 1; j < Program.toolLibrarySystem.toolCategories[i].Length; j++)
                {
                    if (Program.toolLibrarySystem.toolCategories[i][j].toolNameSearch(newTool))
                    {
                        Tool tool = Program.toolLibrarySystem.toolCategories[i][j].GetTool(newTool);
                        Program.toolLibrarySystem.borrowTool(Program.toolLibrarySystem.members.GetMember(MemberMenu.Member()), tool);
                        return;
                    }
                }
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