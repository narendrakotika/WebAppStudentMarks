using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppStudentMarks.Models;

namespace WebAppStudentMarks.Data
{
    public class MarkDbContext : DbContext
    {
        public MarkDbContext (DbContextOptions<MarkDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppStudentMarks.Models.Mark> Mark { get; set; } = default!;
    }
}
