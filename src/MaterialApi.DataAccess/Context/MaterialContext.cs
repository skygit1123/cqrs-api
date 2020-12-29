using System.Linq;
using MaterialApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MaterialApi.DataAccess
{
    public class MaterialContext : DbContext, IMaterialContext
    {
        public MaterialContext(DbContextOptions<MaterialContext> options) : base(options)
        {
            Workers = Set<Worker>();
        }

        public IQueryable<Worker> Workers { get; set; }

        public T Create<T>(T entity) where T : BaseEntity
        {
            return Add<T>(entity).Entity;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set ID to guid
            foreach (var entityType in
                        modelBuilder.Model.GetEntityTypes().Where(t =>
                        t.ClrType.IsSubclassOf(typeof(Entity))))
            {
                modelBuilder.Entity
                (
                    entityType.Name,
                    x =>
                    {
                        x.Property("Id").HasDefaultValueSql("NEWID()");
                    }
                );
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MaterialContext).Assembly);
        }
    }
}
