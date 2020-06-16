﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CV : Document
    {
        private string title;
        private List<Page> pages;
        public override string Title { get => title; set => title=value; }
        public override List<Page> Pages { get => pages; set => pages=value; }

        public CV(string title, List<Page> pages)
        {
            Title = title;
            Pages = pages;
        }
    }
}
