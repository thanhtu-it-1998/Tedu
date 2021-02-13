using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        public CRUDDbContext context;
        public HomeController(CRUDDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var res = context.Products.ToList();
            return Ok(res);
        }
    }
}
