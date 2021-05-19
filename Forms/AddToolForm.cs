using System;

namespace Tools_Library_Application_Software
{
    public class AddToolForm
    {
        public AddToolForm(ToolTypes toolTypes)
        {
            Console.WriteLine("Enter Tool Name: ");
            Console.WriteLine();
            string toolName = Console.ReadLine();

            Console.WriteLine("Enter Tool Quantity: ");
            Console.WriteLine();
            int toolQuantity = validationInt();

            Tool newTool = new Tool(toolName, toolQuantity, toolQuantity, 0);


            for (int i = 1; i < Program.toolLibrarySystem.toolCategories.Length; i++)
            {
                for (int j = 1; j < Program.toolLibrarySystem.toolCategories[i].Length; j++)
                {
                    if (Program.toolLibrarySystem.toolCategories[i][j].toolNameSearch(newTool))
                    {
                        Program.toolLibrarySystem.toolCategories[i][j].addToolQuantity(newTool);
                        return;
                    }
                }
            }
            Program.toolLibrarySystem.add(newTool, toolTypes);
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
