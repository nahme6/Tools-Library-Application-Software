using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class ToolTypeMenu
    {

        Menu toolTypeMenu;

        public ToolTypeMenu(string input)
        {
            switch (input)
            {
                case "1":
                    string[] opt = { "Line Trimmers", "Lawn Mowers", "Hand Mowers", "Wheel Barrows", "Garden Power Tools" };
                    toolTypeMenu = new Menu("Gardening Tools", opt);
                    break;
                case "2":
                    string[] opt = { "Scrapers", "Floor Lasers", "Floor Levelling Tools", "Floor ", "Garden Power Tools" };
                    toolTypeMenu = new Menu("Gardening Tools", opt);


            }


            
        }


        Menu menu = new Menu("Garden Tool Types", toolT);
    }
}
