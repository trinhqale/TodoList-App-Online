using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFirstAzureWebApp.Data;
using MyFirstAzureWebApp.Models;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyFirstAzureWebAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyFirstAzureWebAppContext>>()))
        {
            // Look for any movies.
            if (context.Task.Any())
            {
                return;   // DB has been seeded
            }
            context.Task.AddRange(
                new TodoTask
                {
                    Title = "Tinker Machines Meeting",
                    DueDate = DateTime.Parse("2024-2-12"),
                    Description = "hope no one skips",
                    isCompleted = false
                },
                new TodoTask
                {
                    Title = "Meeting with Professor",
                    DueDate = DateTime.Parse("2024-2-12"),
                    Description = "and her cute students",
                    isCompleted = false
                },
                new TodoTask
                {
                    Title = "Working on AzureApp",
                    DueDate = DateTime.Parse("2024-2-12"),
                    Description = "haizz",
                    isCompleted = false
                }
            );
            context.SaveChanges();
        }
    }
}