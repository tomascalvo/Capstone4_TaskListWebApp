using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4_TaskListWebApp.Context
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public TaskDbContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
