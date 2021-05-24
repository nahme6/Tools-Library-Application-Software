using System;

namespace Tools_Library_Application_Software
{
    class Program
    {
        public static ToolLibrarySystem toolLibrarySystem;
        static void Main(string[] args)
        {
            Tool tool1 = new Tool("Irwin 125mm orbital sander", 5, 3, 2);
            Tool tool2 = new Tool("Rocket sanding block holder", 2, 2, 1);
            Tool tool3 = new Tool("Powerfit 120 triangular sander", 1, 1, 5);

            Member member1 = new Member("Navid", "Ahmed", "0450077117", "0000");
            Member member2 = new Member("Tom", "Riddle", "046523075", "4444");
            Member member3 = new Member("Tony", "Stark", "045028858", "0567");

            toolLibrarySystem = new ToolLibrarySystem();

            toolLibrarySystem.add(tool1, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool2, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool3, ToolTypes.basicHandTools);

            toolLibrarySystem.add(member1);
            toolLibrarySystem.add(member2);
            toolLibrarySystem.add(member3);

            toolLibrarySystem.borrowTool(member1, tool1);

            new MainMenu();
        }
    }
}
