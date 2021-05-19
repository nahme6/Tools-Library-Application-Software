using System;

namespace Tools_Library_Application_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainMenuInput;
            string staffMenuInput;
            ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();

            
            MainMenu.Display();
            

            /*
            string[] mainMenuOptions = { "Staff Login", "Member Login", "Exit" };
            Menu menu = new Menu("Main Menu", mainMenuOptions);
            menu.printMenu();

            mainMenuInput = Console.ReadLine();
            Console.WriteLine();

            while (mainMenuInput != "0")
            {
                switch (mainMenuInput)
                {
                    case "1":
                        string[] staffMenuOptions = {
                            "Add a new tool",
                            "Add new pieces of an existing tool",
                            "Remove some pieces of a tool",
                            "Register a new member",
                            "Remove a member",
                            "Find the contact number of a member",
                            "Return to Main Menu"};
                        Menu staffMenu = new Menu("Staff Menu", staffMenuOptions);
                        staffMenu.printMenu();

                        staffMenuInput = Console.ReadLine();
                        Console.WriteLine();
                            switch (staffMenuInput)
                            {
                                case "1":
                                    new ToolCategoryMenu();

                                    string input = Console.ReadLine();
                                    Console.WriteLine();
                                    
                                    switch "1":
                                    new 


                                     break;
                            }
                    break;
                }
            }


            Environment.Exit(0);

            /*
            MemberCollection memberCollection = new MemberCollection();
            Member member1 = new Member("Navid", "Ahmed", "0450077117", "0000");
            memberCollection.add(member1);
            Member member2 = new Member("Chelsea", "Jenkins", "044565437", "7854");
            memberCollection.add(member2);

            Console.WriteLine(member1.ToString());
            Console.WriteLine(member2.ToString());

            ToolCollection toolCollection = new ToolCollection(20);
            Tool tool1 = new Tool("Chainsaw", 5, 5, 0);
            toolCollection.add(tool1);
            Tool tool2 = new Tool("Hammer", 7, 6, 0);
            toolCollection.add(tool2);

            Console.WriteLine(tool1.ToString());
            Console.WriteLine(tool2.ToString());

            member1.addTool(tool1);
            member2.addTool(tool2);
            */

            /*
            ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();

            Tool tool1 = new Tool("Irwin 125mm orbital sander", 5, 3, 2);
            Tool tool2 = new Tool("Rocket sanding block holder", 2, 1, 1);
            Tool tool3 = new Tool("Powerfit 120 triangular sander", 1, 1, 0);

            Member member1 = new Member("Navid", "Ahmed", "0450077117", "7777");
            Member member2 = new Member("Steve", "Rogers", "0450248454", "0000");
            Member member3 = new Member("Hannah", "Montana", "045365333", "4778");


            toolLibrarySystem.add(tool1, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool2, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool3, ToolTypes.basicHandTools);


            toolLibrarySystem.add(tool1, 2);

            //toolLibrarySystem.delete(tool1, 1);

            //toolLibrarySystem.displayTools("Basic Hand Tools");
            */

            /*
            toolLibrarySystem.add(member1);
            toolLibrarySystem.add(member2);
            toolLibrarySystem.add(member3);

            toolLibrarySystem.borrowTool(member1, tool1);
            toolLibrarySystem.returnTool(member1, tool1);

            toolLibrarySystem.displayBorrowingTools(member1);
            */

            /*
            MemberCollection memberCollection = new MemberCollection();
            ToolCollection toolCollection = new ToolCollection(30);
            Member member1 = new Member("Navid", "Ahmed", "0450077117", "7777");
            Tool axe = new Tool("Axe", 4, 4, 0);
            Tool hammer = new Tool("Hammer", 2, 2, 0);
            toolCollection.add(axe);
            toolCollection.add(hammer);
            member1.addTool(axe);
            memberCollection.add(member1);
            

            //Console.WriteLine(memberCollection.Number);

            axe.addBorrower(member1);

            */



            //MainMenu();
        }
    }
}
