using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class PitalicaContext : DbContext
    {
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestResult> TestResult { get; set; }
        public virtual DbSet<User> User { get; set; }

        public PitalicaContext(DbContextOptions<PitalicaContext> options)
        : base(options)
        { }
    }
}
