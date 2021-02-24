using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDrinkAndGo.Models.Entities;

namespace WebDrinkAndGo.Extension.Interface
{
    public class ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
