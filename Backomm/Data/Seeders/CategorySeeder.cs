using System.Collections.Generic;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Data.Seeders
{
    public static class CategorySeeder
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id =  1,
                    Title = "Arts",
                    Description =  "Art Category",
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 2,
                    Title = "Hobbies",
                    Description =  "Hobby Category",
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 3,
                    Title = "Tech",
                    Description =  "Tech Category",
                });
            
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 4,
                    Title = "Outdoor",
                    Description =  "Outdoor Category",
                });
            
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 5,
                    Title = "Test",
                    Description =  "Test Category",
                });
            
        }
    }
}