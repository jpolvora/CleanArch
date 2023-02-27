using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; } = default!;
        public DbSet<Post> Posts { get; set; } = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
