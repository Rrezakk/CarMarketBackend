using CarMarketBackend.Domain.Models;
using CarMarketBackend.Domain.Models.JWT;
using Microsoft.EntityFrameworkCore;

namespace CarMarketBackend.DataAccessLayer.Contexts;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //packet has multiple dares
        /*modelBuilder.Entity<Dare>()
            .HasOne<Packet>(s => s.Packet)
            .WithMany(g => g.Dares)
            .HasForeignKey(s => s.PacketId);
        modelBuilder.Entity<Dare>()
            .HasOne<Category>(s => s.Category)
            .WithMany(g => g.Dares)
            .HasForeignKey(s => s.CategoryId);
        modelBuilder.Entity<Dare>()
            .HasMany<Item>(d => d.Items)
            .WithMany(g => g.Dares);*/
        /*modelBuilder.Entity<Dare>()
            .HasOne<Packet>(s => s.Packet)
            .WithMany(g => g.Dares)
            .HasForeignKey(s => s.PacketId);*/
        
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Account> Accounts { get; set; } = null!;

}