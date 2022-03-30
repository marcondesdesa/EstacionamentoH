using EstacionamentoH.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstacionamentoH.Infra.Data
{
    public partial class EstacionamentoHContextDb : DbContext
    {
        public EstacionamentoHContextDb()
        {
        }
        public EstacionamentoHContextDb(DbContextOptions<EstacionamentoHContextDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Condutor> Condutores { get; set; }
        public virtual DbSet<Estacionamento> Estacionamentos { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Preco> Precos { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EstacionamentoH;Persist Security Info=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estacionamento>()
                    .Property(s => s.DataEntrada)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia0)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia1)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia2)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia3)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia4)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia5)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");

            modelBuilder.Entity<Parametro>()
                   .Property(s => s.Dia6)
                   .HasColumnType("bit").
                   HasDefaultValueSql("0");
        }
    }
}