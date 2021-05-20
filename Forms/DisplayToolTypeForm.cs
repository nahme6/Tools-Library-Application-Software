using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class DisplayToolTypeForm
    {
        public DisplayToolTypeForm()
        {
            Console.WriteLine("Enter Tool Type: ");
            string toolType = Console.ReadLine();

            Program.toolLibrarySystem.displayTools(toolType);
        }
    }
}
