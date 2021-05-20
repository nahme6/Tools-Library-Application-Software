using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class ReturnToolForm
    {
        public ReturnToolForm()
        {
            Console.WriteLine("Enter Tool Name: ");
            Console.WriteLine();
            string toolName = Console.ReadLine();
            Tool searchTool = new Tool(toolName);

            for (int i = 1; i < Program.toolLibrarySystem.toolCategories.Length; i++)
            {
                for (int j = 1; j < Program.toolLibrarySystem.toolCategories[i].Length; j++)
                {
                    Member member = Program.toolLibrarySystem.members.GetMember(MemberMenu.Member());
                    if (member.isBorrowingTool(searchTool))
                    {
                        Program.toolLibrarySystem.toolCategories[i][j].removeToolQuantity(searchTool);
                        Console.WriteLine("Quantity Updated \n");
                        return;
                    }
                }
            }
            Console.WriteLine("Tool not found or not borrowed\n");
        }
    }    
}
