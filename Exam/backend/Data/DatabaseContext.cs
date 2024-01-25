using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class DatabaseContext: DbContext
{
    public DbSet<Test> Tests { get; set; }


    public DbSet<Autor> Autor { get; set; }
    public DbSet<Carte> Carte { get; set; }

    public DbSet<Editura> Editura { get; set; }
    public DbSet<AutorCarteRelatie> AutorCarteRelaties { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One to Many
        modelBuilder.Entity<Editura>()
                    .HasMany(m1 => m1.Autori)
                    .WithOne(m2 => m2.Editura);


        
        // Many to Many
        modelBuilder.Entity<AutorCarteRelatie>().HasKey(mr => new { mr.AutorId, mr.CarteId });

        // One to many for m-m
        modelBuilder.Entity<AutorCarteRelatie>()
                    .HasOne(mr => mr.Autor)
                    .WithMany(m3 => m3.AutorCarteRelatie)
                    .HasForeignKey(mr => mr.AutorId);

        modelBuilder.Entity<AutorCarteRelatie>()
                    .HasOne(mr => mr.Carte)
                    .WithMany(m4 => m4.AutoriCarteRelatie)
                    .HasForeignKey(mr => mr.CarteId);

        base.OnModelCreating(modelBuilder);
    }
}