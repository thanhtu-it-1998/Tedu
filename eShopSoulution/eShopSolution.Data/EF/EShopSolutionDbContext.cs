﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopSolutionDbContext:DbContext
    {
        public EShopSolutionDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
