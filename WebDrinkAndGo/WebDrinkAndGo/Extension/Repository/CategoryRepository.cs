using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDrinkAndGo.Extension.Interface;
using WebDrinkAndGo.Models.EF;
using WebDrinkAndGo.Models.Entities;

namespace WebDrinkAndGo.Extension.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
