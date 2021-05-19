using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class Menu1
    {
        private string title;
        private string[] selections;
        public int input;
        public Menu1(string title, string[] selections)
        {
            this.title = title;
            this.selections = selections;
        }

        public string Title
        {
            get => title;
        }

        public string[] Selections
        {
            get => selections;
        }

        public void writeMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine(("").PadLeft(11, '=') + "{0}" + ("").PadRight(11, '='), title);

            for (int i = 0; i < selections.Length - 1; i++)
            {
                Console.WriteLine(
                "{0}. {1}",
                i + 1, selections[i]);
            }

            Console.WriteLine(
                "{0}. {1}",
                0, selections[selections.Length - 1]);

            Console.WriteLine(("").PadLeft(11 * 2 + title.Length, '='));
            Console.WriteLine("\nPlease Make a selection (1-{0}, or 0 to {1}):", selections.Length - 1, selections[selections.Length - 1]);
        }
    }
}

    /*
    public class MainMenu
    {
        static Menu mainMenu;
        static bool showMenu = true;

        public MainMenu()
        {
            string[] selection = { "Staff Login", "Member Login", "Exit" };
            mainMenu = new Menu("Main Menu", selection);
        }

        public static void Display()
        {
            mainMenu.writeMenu();

            switch (Console.ReadLine())
            {
                case "0":
                    break;
                case "1":
                    StaffMenu.Display();
                    break;
            }
        }
    }

    public class StaffMenu
    {
        static Menu staffMenu;
        static bool showMenu = true;

        public StaffMenu()
        {
            string[] selection = { 
                "Add a new tool",
                "Add new pieces of an existing tool",
                "Remove some pieces of a tool",
                "Register a new member",
                "Remove a member",
                "Find the contact number of a member",
                "Return to Main Menu"};
            staffMenu = new Menu("Staff Menu", selection);
        }

        public static void Display()
        {
            staffMenu.writeMenu();

            switch (Console.ReadLine())
            {
                case "0":
                    MainMenu.Display();
                    break;
                case "1":
                    ToolCategoryMenu.Display();
                    break;
            }
        }
    }

    public class ToolCategoryMenu
    {
        static Menu toolCategoryMenu;

        public ToolCategoryMenu()
        {
            string[] selection = {
                "Gardening Tools",
                "Flooring Tools",
                "Fencing Tools",
                "Measuring Tools",
                "Cleaning Tools",
                "Painting Tools",
                "Electronic Tools",
                "Electricity Tools",
                "Automotive Tools",
                "Return to previous menu"};
            toolCategoryMenu = new Menu("Tool Categories", selection);
        }

        public static bool Display()
        {
            toolCategoryMenu.writeMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    new ToolType("Gardening Tools");
                        ToolType.Display();
                    return true;
                case "2":
                    new ToolType("Flooring Tools");
                    ToolType.Display();
                    return true;
                case "3":
                    new ToolType("Measuring Tools");
                    ToolType.Display();
                    return true;
                case "4":
                    new ToolType("Measuring Tools");
                    ToolType.Display();
                    return true;
                default:
                    return true;
            }
        }
    }

    public class ToolType
    {
        static Menu toolTypeMenu;
        public ToolType(string toolCategory)
        {
            switch (toolCategory)
            {
                case "Gardening Tools":
                    string[] selection1 = {
                        "Line Trimmers",
                        "Lawn Mowers",
                        "Hand Mowers",
                        "Wheel Barrows",
                        "Garden Power Tools"};
                    toolTypeMenu = new Menu(toolCategory, selection1);
                    break;
                case "Flooring Tools":
                    string[] selection2 = {
                        "Scapers",
                        "Floor Lasers",
                        "Floor Levelling Tools",
                        "Floor Levelling Materials",
                        "Floor Hand Tools",
                        "Tiling Tools"};
                    toolTypeMenu = new Menu(toolCategory, selection2);
                    break;
                case "Fencing Tools":
                    string[] selection3 = {
                        "Hand Tools",
                        "Electric Fencing",
                        "Steel Fencing Tools",
                        "Power Tools",
                        "Fencing Accessories"};
                    toolTypeMenu = new Menu(toolCategory, selection3);
                    break;
                case "Measuring Tools":
                    string[] selection4 = {
                        "Distance Tools",
                        "Laser Measurer",
                        "Measuring Jugs",
                        "Tempreture & Humidity Tools",
                        "Levelling Tools",
                        "Markers"};
                    toolTypeMenu = new Menu(toolCategory, selection4);
                    break;
                case "Cleaning Tools":
                    string[] selection5 = {
                        "Draining",
                        "Car Cleaning",
                        "Vacuum",
                        "Pressure Cleaners",
                        "Pool Cleaning",
                        "Floor Cleaning"};
                    toolTypeMenu = new Menu(toolCategory, selection5);
                    break;
                case "Painting Tools":
                    string[] selection6 = {
                        "Sanding Tools",
                        "Brushes",
                        "Rollers",
                        "Paint Removal Tools",
                        "Paint Scrapers",
                        "Sprayers"};
                    toolTypeMenu = new Menu(toolCategory, selection6);
                    break;
                case "Electronic Tools":
                    string[] selection7 = {
                        "Voltage Tester",
                        "Oscilloscopes",
                        "Thermal Imaging",
                        "Data test Tools",
                        "Insulation Testers"};
                    toolTypeMenu = new Menu(toolCategory, selection7);
                    break;
                case "Electricity Tools":
                    string[] selection8 = {
                        "Test Equipment",
                        "Safety Equipment",
                        "Basic Hand Tools",
                        "Circuit Protection",
                        "Cable Tools"};
                    toolTypeMenu = new Menu(toolCategory, selection8);
                    break;
                case "Automotive Tools":
                    string[] selection9 = {
                        "Jacks",
                        "Air Compressors",
                        "Battery Chargers",
                        "Socket Tools",
                        "Braking",
                        "Drivetrain"};
                    toolTypeMenu = new Menu(toolCategory, selection9);
                    break;
            }
        }

        public static bool Display()
        {
            if (toolTypeMenu.Selections.Length == 5)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        // Add tool Form
                        return true;
                    case "2":
                        Member.StaffMenuDisplay();
                        return true;
                    case "3":
                        return false;
                    case "4":
                    case "5";
                    default:
                        return true;
                }
            } else if (toolTypeMenu.Selections.Length == 6)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        ToolTypeGardenMenu.ToolTypeGardenMenuDisplay();
                        return true;
                    case "2":
                        Member.StaffMenuDisplay();
                        return true;
                    case "3":
                        return false;
                    case "4":
                    case "5";
                    case "6":
                    default:
                        return true;
                }
            } else
            {
                return true;
            }
            return true;
        }
    }
}
*/
