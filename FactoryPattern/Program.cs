using FactoryPattern.Generators;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentGenerator document=null;
            Console.Write("What do you want to generate(CV,Story,Report):");
            string doc=Console.ReadLine();

            switch (doc)
            {
                case "CV":
                    document = new CVGenerator();
                    break;
                case "Story":
                    document = new StoryGenerator();
                    break;
                case "Report":
                    document = new ReportGenerator();
                    break;
            }

            Document NewDoc = document.CreateDocument();
            foreach(Page page in NewDoc.Pages)
            {
                Console.WriteLine(page.ToString());
            }
        }
    }
}
