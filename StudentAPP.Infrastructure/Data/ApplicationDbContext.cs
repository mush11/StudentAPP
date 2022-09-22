using Microsoft.EntityFrameworkCore;
using StudentAPP.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPP.Infrastructure.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Gender> Gender { get; set; }
        public DbSet<StudentInfo> StudentInfo { get; set; }
    }
}
