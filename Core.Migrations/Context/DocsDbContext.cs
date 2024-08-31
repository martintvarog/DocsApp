using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Migrations.Context;

public class DocsDbContext : DbContext
{
    public DbSet<Document> Documents { get; set; }
    public DbSet<AdditionalData> AdditionalData { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<DocumentTags> DocumentTags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=localhost;Initial Catalog=DocumentsApp;User=sa;Password=R4hf+~h}7hdw4*W%;;Trusted_Connection=False;Encrypt=False");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocumentTags>()
            .HasKey(dt => new { dt.DocumentId, dt.TagId });
        
        // modelBuilder.Entity<DocumentTags>()
        //     .HasOne(dt => dt.Document)
        //     .WithMany(d => d.DocumentTags)
        //     .HasForeignKey(dt => dt.DocumentId);
        //
        // modelBuilder.Entity<DocumentTags>()
        //     .HasOne(dt => dt.Tag)
        //     .WithMany(t => t.DocumentTags)
        //     .HasForeignKey(dt => dt.TagId);
    }
}