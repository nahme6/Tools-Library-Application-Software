using System;
using System.Collections.Generic;
using System.Text;

namespace Tools_Library_Application_Software
{
    public class MenuDetails
    {
        private string title;
        private string[] selection;
        public MenuDetails(string title, string[] selection)
        {
            this.title = title;
            this.selection = selection;
        }

        public string Title
        {
            get => title;
        }

        public string[] Selection
        {
            get => selection;
        }
    }
}
