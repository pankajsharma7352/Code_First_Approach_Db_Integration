﻿
using DBIntegration.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace DBIntegration.Db.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
