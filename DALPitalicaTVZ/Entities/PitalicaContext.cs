using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class PitalicaContext : DbContext
    {
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamResult> ExamResults { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public PitalicaContext(DbContextOptions<PitalicaContext> options)
        : base(options)
        { }

        public PitalicaContext()
        { }
    }
}
