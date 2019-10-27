using System.Collections.Generic;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Data.Seeders
{
    public static class GroupSeeder
    {
        public static void GroupSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    Id =  1,
                    Title = "Group 1 Test",
                    Description =  "Group 1 Description",
                });
        }
    }
}