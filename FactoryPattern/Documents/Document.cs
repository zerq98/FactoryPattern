using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Document
    {
        public abstract string Title { get; set; }
        public abstract List<Page> Pages { get; set; } 
    }
}
