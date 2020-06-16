using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Generators
{
    class ReportGenerator : DocumentGenerator
    {
        string title;
        int PageNumber;
        List<Page> pages;

        public ReportGenerator()
        {
            PageNumber = 1;
            title = "Title page";
            pages = new List<Page>
            {
                CreatePage("Gains",PageNumber++),
                CreatePage("Loss",PageNumber++),
                CreatePage("Conclusion",PageNumber)
            };
        }
        public override Document CreateDocument()
        {
            return new Report(title, pages);
        }
    }
}
