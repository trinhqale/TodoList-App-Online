using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstAzureWebApp.Models;

namespace MyFirstAzureWebApp.Data
{
    public class MyFirstAzureWebAppContext : DbContext
    {
        public MyFirstAzureWebAppContext (DbContextOptions<MyFirstAzureWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstAzureWebApp.Models.TodoTask> Task { get; set; } = default!;
    }
}
