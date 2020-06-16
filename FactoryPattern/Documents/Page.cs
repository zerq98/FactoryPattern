using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Page
    {
        public string Title { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"#{Number}. {Title}";
        }
    }
}
