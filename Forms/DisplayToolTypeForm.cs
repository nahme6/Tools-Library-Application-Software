using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software.Forms
{
    class DisplayToolTypeForm
    {
        public DisplayToolTypeForm()
        {
            Console.WriteLine("Enter Tool Type: ");
            string toolType = Console.ReadLine();

            string[] selection = {

                "Line Trimmers",
                "Lawn Mowers",
                "Hand Mowers",
                "Wheel Barrows",
                "Garden Power Tools",
                "Scapers",
                "Floor Lasers",
                "Floor Levelling Tools",
                "Floor Levelling Materials",
                "Floor Hand Tools",
                "Tiling Tools",
                "Hand Tools",
                "Electric Fencing",
                "Steel Fencing Tools",
                "Power Tools",
                "Fencing Accessories",
                "Distance Tools",
                "Laser Measurer",
                "Measuring Jugs",
                "Tempreture & Humidity Tools",
                "Levelling Tools",
                "Markers",
                "Draining",
                "Car Cleaning",
                "Vacuum",
                "Pressure Cleaners",
                "Pool Cleaning",
                "Floor Cleaning",
                "Sanding Tools",
                "Brushes",
                "Rollers",
                "Paint Removal Tools",
                "Paint Scrapers",
                "Sprayers",
                "Voltage Tester",
                "Oscilloscopes",
                "Thermal Imaging",
                "Data test Tools",
                "Insulation Testers",
                "Test Equipment",
                "Safety Equipment",
                "Basic Hand Tools",
                "Circuit Protection",
                "Cable Tools",
                "Jacks",
                "Air Compressors",
                "Battery Chargers",
                "Socket Tools",
                "Braking",
                "Drivetrain"};

            switch (toolType)
            {
                case selection[0]:
                    Program.toolLibrarySystem.displayTools()
            }
        }
    }
}
