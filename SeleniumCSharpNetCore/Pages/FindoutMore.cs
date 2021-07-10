using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class FindoutMore : DriverHelper
    {
        public string getPageTitle()
        {
            return Driver.Title;
        }
    }
}
