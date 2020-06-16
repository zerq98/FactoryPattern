using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Generators
{
    class CVGenerator : DocumentGenerator
    {
        string title;
        int PageNumber;
        List<Page> pages;

        public CVGenerator()
        {
            PageNumber = 1;
            title = "Title page";
            pages = new List<Page>
            {
                CreatePage("Experience",PageNumber++),
                CreatePage("Skills",PageNumber++),
                CreatePage("School",PageNumber)
            };
        }
        public override Document CreateDocument()
        {
            return new CV(title, pages);
        }
    }
}
