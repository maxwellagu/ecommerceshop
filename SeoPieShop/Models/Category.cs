﻿using System.Collections.Generic;

namespace SeoPieShop.Models
{
    public class Category
    {
        //public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
