using Infrastructure.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFrameworkCore;

public class DocsDbContext : DbContext
{
    public DbSet<DocumentEntity> Documents => Set<DocumentEntity>();

    public DocsDbContext(DbContextOptions<DocsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocumentEntity>()
            .HasKey(x => x.Id);
    }
}