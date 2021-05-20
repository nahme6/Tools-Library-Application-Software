using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    class MCleaningToolTypeMenu
    {
        public int[] selection;
        public MenuDetails menuDetails;
        public static string title;
        public static string[] menuSelection;
        public MCleaningToolTypeMenu()
        {
            string[] selection = {
                "Draining",
                "Car Cleaning",
                "Vacuum",
                "Pressure Cleaners",
                "Pool Cleaning",
                "Floor Cleaning",
                "Return to previous menu"};
            menuDetails = new MenuDetails("Tool Categories", selection);
            title = menuDetails.Title;
            menuSelection = menuDetails.Selection;

            int menuOption;
            do
            {
                writeMenu(menuDetails);
                menuOption = ReadOption();

                if (menuOption != 0)
                {
                    toolCategoryMenuNext(menuOption);
                }
            } while (menuOption != 0);
        }
        public void writeMenu(MenuDetails menuDetails)
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine(("").PadLeft(11, '=') + "{0}" + ("").PadRight(11, '='), menuDetails.Title);

            for (int i = 0; i < menuDetails.Selection.Length - 1; i++)
            {
                Console.WriteLine(
                "{0}. {1}",
                i + 1, menuDetails.Selection[i]);
            }

            Console.WriteLine(
                "{0}. {1}",
                0, menuDetails.Selection[menuDetails.Selection.Length - 1]);

            Console.WriteLine(("").PadLeft(11 * 2 + menuDetails.Title.Length, '='));
            Console.WriteLine("\nPlease Make a selection (1-{0}, or 0 to {1}):", menuDetails.Selection.Length - 1, menuDetails.Selection[menuDetails.Selection.Length - 1]);
        }
        // Validation method for menu options
        public int ReadOption()
        {
            string selection;
            int option;
            bool okayChoice;
            int menuSelection = menuDetails.Selection.Length;

            do
            {
                selection = Console.ReadLine();
                okayChoice = int.TryParse(selection, out option);
                if (!okayChoice || option < 0 || option > menuSelection)
                {
                    okayChoice = false;
                    Console.WriteLine("You did not enter a correct option.\n\n Please try again");
                    writeMenu(menuDetails);
                }
            } while (!okayChoice);
            return option;
        }

        public static void toolCategoryMenuNext(int menuOption)
        {
            switch (menuOption)
            {
                case 1:
                    new BorrowToolForm(ToolTypes.draining);
                    break;
                case 2:
                    new BorrowToolForm(ToolTypes.carCleaning);
                    break;
                case 3:
                    new BorrowToolForm(ToolTypes.vacuum);
                    break;
                case 4:
                    new BorrowToolForm(ToolTypes.pressureCleaners);
                    break;
                case 5:
                    new BorrowToolForm(ToolTypes.poolCleaning);
                    break;
                case 6:
                    new BorrowToolForm(ToolTypes.floorCleaning);
                    break;
            }
        }
    }
}
