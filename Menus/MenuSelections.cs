using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software.Menus
{
    public class MenuSelections
    {
        string[] menuSelections;
        int menuSelectionNo;
        public MenuSelections(string[] menuSelection, int menuSelectionNo)
        {
            this.menuSelections = menuSelection;
            this.menuSelectionNo = menuSelectionNo;
        }
    }
}
