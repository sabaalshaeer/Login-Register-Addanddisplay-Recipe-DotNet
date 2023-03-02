using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Models;
using pantry_collabAPI.test.Models;
using System.Collections.Generic;

namespace pantry_collabAPI.Data
{
    public class PantryDbContext : DbContext
    {//1st: we will have to configure where our API should go, Database should get Map
        public PantryDbContext(DbContextOptions options) : base(options){ }

        //Map the Employee ,User, andUserRole and give it a name
        public DbSet<User> Users { get; set; }
        public DbSet<PantryItem> PantryItems {get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<MyModel> MyModels { get; set; }

    }
}
