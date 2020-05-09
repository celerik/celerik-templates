using Microsoft.EntityFrameworkCore;

namespace {{namespace}}.EntityFramework
{
    public partial class {{short-namespace}}DbContext : DbContext
    {
        public {{short-namespace}}DbContext()
        {
        }

        public {{short-namespace}}DbContext(DbContextOptions<{{short-namespace}}DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<{{main-entity}}> {{main-entity}} { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<{{main-entity}}>(entity =>
            {
                entity.ToTable("{{main-entity}}", "{{db-schema}}");

                entity.Property(e => e.{{main-entity}}Id).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
