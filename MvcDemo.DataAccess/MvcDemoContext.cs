using System.Data.Entity;
using System.Configuration;
using MvcDemo.Common.Entities;
using System;
using MvcDemo.Common.Extensions;
using System.Data.Entity.ModelConfiguration;

namespace MvcDemo.DataAccess
{
    public interface IContext
    {
        DbSet<CoursePortal> CoursePortals { get; set; }
        DbSet<Portal> Portals { get; set; }
        DbSet<Registration> Registrations { get; set; }
        DbSet<User> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }


    public class MvcDemoContext : DbContext, IContext
    {
        
        //Turn off the DB initializer in order not to recreate the database
        public MvcDemoContext()
        {
            Database.SetInitializer<MvcDemoContext>(null);
        }
                
        public virtual DbSet<CoursePortal> CoursePortals { get; set; }
        public virtual DbSet<Portal> Portals { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MvcDemoContext"].ConnectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mappings = GetType().Assembly.GetInheritedTypes(typeof(EntityTypeConfiguration<>));
            foreach (var mapping in mappings)
            {
                dynamic instance = Activator.CreateInstance(mapping);
                modelBuilder.Configurations.Add(instance);
            }

            //Define the relationships between tables/objects
            modelBuilder.Entity<CoursePortal>()
               .HasMany(e => e.Registrations)
               .WithRequired(e => e.CoursePortal)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<Portal>()
                .HasMany(e => e.CoursePortals)
                .WithRequired(e => e.Portal)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<User>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

        }


      
    }
}
