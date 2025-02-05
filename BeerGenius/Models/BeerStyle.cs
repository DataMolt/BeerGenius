﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerGenius.Models
{

    public class StyleRequest
    {
        public string message { get; set; }
        public BeerStyle[] data { get; set; }
        public string status { get; set; }
    }

    public class BeerStyle
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string description { get; set; }
        public string ibuMin { get; set; }
        public string ibuMax { get; set; }
        public string abvMin { get; set; }
        public string abvMax { get; set; }
        public string srmMin { get; set; }
        public string srmMax { get; set; }
        public string ogMin { get; set; }
        public string fgMin { get; set; }
        public string fgMax { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string ogMax { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string createDate { get; set; }
        public string description { get; set; }
        public string updateDate { get; set; }
    }
}
