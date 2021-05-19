using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class FlooringToolTypeMenu
    {
        public int[] selection;
        public MenuDetails menuDetails;
        public static string title;
        public static string[] menuSelection;
        public FlooringToolTypeMenu()
        {
            string[] selection = {
                "Scapers",
                "Floor Lasers",
                "Floor Levelling Tools",
                "Floor Levelling Materials",
                "Floor Hand Tools",
                "Tiling Tools",
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
                    flooringToolTypeMenuNext(menuOption);
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

        public static void flooringToolTypeMenuNext(int menuOption)
        {
            switch (menuOption)
            {
                case 1:
                    new AddToolForm(ToolTypes.scrapers);
                    break;
                case 2:
                    new AddToolForm(ToolTypes.floorLasers);
                    break;
                case 3:
                    new AddToolForm(ToolTypes.floorLevellingTools);
                    break;
                case 4:
                    new AddToolForm(ToolTypes.floorLevellingMaterials);
                    break;
                case 5:
                    new AddToolForm(ToolTypes.floorHandTools);
                    break;
                case 6:
                    new AddToolForm(ToolTypes.tilingTools);
                    break;
            }
        }
    }
}
