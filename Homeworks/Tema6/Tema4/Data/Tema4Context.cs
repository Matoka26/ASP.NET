using Microsoft.EntityFrameworkCore;
using Tema4.Models;
using Tema4.Models.One_to_Many;
using Tema4.Models.One_to_One;
using Tema4.Models.Many_to_Many;

namespace Tema4.Data
{
    public class Tema4Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        //1:M
        public DbSet<Model1> Models1 { get; set; }
        public DbSet<Model2> Models2 { get; set; }

        //1:1
        public DbSet<Model5> Models5 { get; set; }
        public DbSet<Model6> Models6 { get; set; }

        //M:M
        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }
        public DbSet<ModelsRelation> modelsRelations { get; set; }

        public DbSet<User> Users { get; set; }

        public Tema4Context(DbContextOptions<Tema4Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1:M
            modelBuilder.Entity<Model1>()
                        .HasMany(m1 => m1.Models2)
                        .WithOne(m2 => m2.Models1);
            //sau invers models1 cu models2 si hasMany,withOne

            //1:1
            modelBuilder.Entity<Model5>()
                        .HasOne(m5 => m5.Models6)
                        .WithOne(m6 => m6.Models5)
                        .HasForeignKey<Model6>(m6 => m6.Model5Id);

            modelBuilder.Entity<ModelsRelation>()
                        .HasKey(mr => new { mr.Model3Id, mr.Model4Id });

            //M:M
            //Model3
            modelBuilder.Entity<ModelsRelation>()
                        .HasOne(mr => mr.Model3)
                        .WithMany(m3 => m3.ModelsRelations)
                        .HasForeignKey(mr => mr.Model3Id);
            //Model4

            modelBuilder.Entity<ModelsRelation>()
                        .HasOne(mr => mr.Model4)
                        .WithMany(m4 => m4.ModelsRelations)
                        .HasForeignKey(mr => mr.Model4Id);

            base.OnModelCreating(modelBuilder);

        }
    }

}
