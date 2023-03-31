﻿using Films.Models;
using Microsoft.EntityFrameworkCore;
namespace ASP.NET_CORE_WEB_APP_MVC_SHOP.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}
