using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinkAndGo.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}