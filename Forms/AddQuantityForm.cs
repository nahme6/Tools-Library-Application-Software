using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class AddQuantityForm
    {
        public AddQuantityForm()
        {
            Console.WriteLine("Enter Tool Name: ");
            Console.WriteLine();
            string toolName = Console.ReadLine();
            Tool searchTool = new Tool(toolName);

            for (int i = 1; i < Program.toolLibrarySystem.toolCategories.Length; i++)
            {
                for (int j = 1; j < Program.toolLibrarySystem.toolCategories[i].Length; j++)
                {
                    if (Program.toolLibrarySystem.toolCategories[i][j].toolNameSearch(searchTool))
                    {
                        Console.WriteLine("Enter Tool Quantity: ");
                        int toolQuantity = validationInt();
                        searchTool = new Tool(toolName, toolQuantity);
                        Program.toolLibrarySystem.toolCategories[i][j].addToolQuantity(searchTool);
                        Console.WriteLine("Quantity Updated \n");
                        return;
                    }
                }
            }
            Console.WriteLine("Tool not found \n");
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
