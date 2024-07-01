using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Data.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BeautyInBloom.API.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        IEnumerable<EntityEntry> modified = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
        foreach (EntityEntry item in modified)
        {
            if (item.Entity is IDateTracking changedOrAddedItem)
            {
                if (item.State == EntityState.Added)
                {
                    changedOrAddedItem.CreatedAt = DateTime.Now;
                }
                else
                {
                    changedOrAddedItem.UpdatedAt = DateTime.Now;
                }
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Role>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Command>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Function>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Brand>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Category>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Order>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<OrderItem>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Product>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Review>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);

        builder.Entity<CommandInFunction>()
            .HasOne(x => x.Function)
            .WithMany(x => x.CommandInFunctions)
            .HasForeignKey(x => x.FunctionId);
        builder.Entity<CommandInFunction>()
            .HasOne(x => x.Command)
            .WithMany(x => x.CommandInFunctions)
            .HasForeignKey(x => x.CommandId);
        
        builder.Entity<Product>()
            .HasOne(x => x.Brand)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.BrandId);
        builder.Entity<Product>()
            .HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
        
        builder.Entity<Review>()
            .HasOne(x => x.Product)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.ProductId);
        builder.Entity<Review>()
            .HasOne(x => x.User)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.UserId);
        
        builder.Entity<OrderItem>()
            .HasOne(x => x.Product)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.ProductId);
        builder.Entity<OrderItem>()
            .HasOne(x => x.Order)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.OrderId);
        
        builder.Entity<Order>()
            .HasOne(x => x.User)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.UserId);

        builder.Entity<Permission>()
            .HasOne(x => x.Function)
            .WithMany(x => x.Permissions)
            .HasForeignKey(x => x.FunctionId);
        builder.Entity<Permission>()
            .HasOne(x => x.Role)
            .WithMany(x => x.Permissions)
            .HasForeignKey(x => x.RoleId);
        builder.Entity<Permission>()
            .HasOne(x => x.Command)
            .WithMany(x => x.Permissions)
            .HasForeignKey(x => x.CommandId);
    }

    public DbSet<User> Users { set; get; }
    public DbSet<Role> Roles { set; get; }
    public DbSet<Command> Commands { set; get; }
    public DbSet<CommandInFunction> CommandInFunctions { set; get; }
    public DbSet<Function> Functions { set; get; }
    public DbSet<Permission> Permissions { set; get; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
}