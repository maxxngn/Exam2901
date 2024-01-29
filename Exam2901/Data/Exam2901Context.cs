using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exam2901.Models;

namespace Exam2901.Data
{
    public class Exam2901Context : DbContext
    {
        public Exam2901Context (DbContextOptions<Exam2901Context> options)
            : base(options)
        {
        }

        public DbSet<Exam2901.Models.Department> Department { get; set; } = default!;
        public DbSet<Exam2901.Models.Employee> Employee { get; set; } = default!;
    }
}
