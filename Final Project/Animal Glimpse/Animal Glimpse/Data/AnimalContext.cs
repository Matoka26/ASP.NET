using Microsoft.EntityFrameworkCore;
using Animal_Glimpse.Models;
namespace Animal_Glimpse.Data
{
    public class AnimalContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<React> Reacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Comments> Commentss {  get; set; }  
        public DbSet<Reaction> Reactions { get; set; }
       
        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // User - Profile: One-to-One
            modelBuilder.Entity<User>()
                .HasOne(user => user.Profile)
                .WithOne(profile => profile.User)
                .HasForeignKey<Profile>(profile => profile.UserId);

            // User -> Post: One-to-Many
            modelBuilder.Entity<User>()
                .HasMany(user => user.Posts)
                .WithOne(post => post.User);

            // User <-> Post: Many-to-Many (Comment)
            modelBuilder.Entity<Comments>()
                .HasKey(comment => comment.CommentId);

            modelBuilder.Entity<Comments>()
                .HasOne(comment => comment.User)
                .WithMany(user => user.Commentss)
                .HasForeignKey(comment => comment.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comments>()
                .HasOne(comment => comment.Post)
                .WithMany(post => post.Commentss)
                .HasForeignKey(comment => comment.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            // User <-> Post <-> React: Many-to-Many-to-Many (Reaction)
            modelBuilder.Entity<Reaction>()
                .HasKey(reaction => new { reaction.UserId, reaction.PostId, reaction.ReactId });

            modelBuilder.Entity<Reaction>()
                .HasOne(reaction => reaction.User)
                .WithMany(user => user.Reactions)
                .HasForeignKey(reaction => reaction.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reaction>()
                .HasOne(reaction => reaction.Post)
                .WithMany(post => post.Reactions)
                .HasForeignKey(reaction => reaction.PostId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Reaction>()
                .HasOne(reaction => reaction.React)
                .WithMany(react => react.Reactions)
                .HasForeignKey(reaction => reaction.ReactId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
