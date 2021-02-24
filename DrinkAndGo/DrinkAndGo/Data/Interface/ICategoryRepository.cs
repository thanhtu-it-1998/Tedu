using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Interface
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
