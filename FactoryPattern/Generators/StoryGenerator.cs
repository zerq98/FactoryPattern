using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Generators
{
    class StoryGenerator : DocumentGenerator
    {
        string title;
        int PageNumber;
        List<Page> pages;

        public StoryGenerator()
        {
            PageNumber = 1;
            title = "Title page";
            pages = new List<Page>
            {
                CreatePage("Chapter 1",PageNumber++),
                CreatePage("Chapter 2",PageNumber++),
                CreatePage("End",PageNumber)
            };
        }
        public override Document CreateDocument()
        {
            return new Story(title, pages);
        }
    }
}
