﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDrinkAndGo.Models.Entities;

namespace WebDrinkAndGo.Views.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks { get; set; }
    }
}
