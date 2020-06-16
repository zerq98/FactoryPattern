using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class DocumentGenerator
    {
        public abstract Document CreateDocument();

        public Page CreatePage(string title,int number)
        {
            return new Page { Title = title, Number = number };
        }
    }
}
