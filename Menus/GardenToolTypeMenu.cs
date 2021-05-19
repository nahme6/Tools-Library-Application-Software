using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class GardenToolTypeMenu
    {
        public int[] selection;
        public MenuDetails menuDetails;
        public static string title;
        public static string[] menuSelection;

        public GardenToolTypeMenu()
        {
            string[] menuSelection = {
                "Line Trimmers",
                "Lawn Mowers",
                "Hand Mowers",
                "Wheel Barrows",
                "Garden Power Tools",
                "Return to previous menu"};
            menuDetails = new MenuDetails("Garden Tool Types", menuSelection);
            title = menuDetails.Title;
            menuSelection = menuDetails.Selection;

            int menuOption;
            do
            {
                writeMenu(menuDetails);
                menuOption = ReadOption();

                if (menuOption != 0)
                {
                    gardenToolTypeMenuNext(menuOption);
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

        public static void gardenToolTypeMenuNext(int menuOption)
        {
            switch (menuOption)
            {
                case 1:
                    new AddToolForm(ToolTypes.lineTrimmers);
                    break;
                case 2:
                    new AddToolForm(ToolTypes.lawnMowers);
                    break;
                case 3:
                    new AddToolForm(ToolTypes.handMowers);
                    break;
                case 4:
                    new AddToolForm(ToolTypes.wheelBarrows);
                    break;
                case 5:
                    new AddToolForm(ToolTypes.gardenPowerTools);
                    break;
            }
        }
    }
}

