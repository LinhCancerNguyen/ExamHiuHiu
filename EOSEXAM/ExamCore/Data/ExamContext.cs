using ExamCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamCore.ModelViews;

namespace ExamCore.Data
{
    public class ExamContext: DbContext
    {
        public ExamContext(DbContextOptions<ExamContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<ResultDetail> ResultDetail { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<User> User { get; set; }
    }
}
