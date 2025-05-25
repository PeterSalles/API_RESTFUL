using Microsoft.EntityFrameworkCore;
using CadastroProdutosApi.Models;

namespace CadastroProdutosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "Teclado", Preco = 100.50m, Quantidade = 10 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 50.00m, Quantidade = 20 },
                new Produto { Id = 3, Nome = "Monitor", Preco = 1200.00m, Quantidade = 5 },
                new Produto { Id = 4, Nome = "Gabinete", Preco = 300.00m, Quantidade = 8 },
                new Produto { Id = 5, Nome = "Fonte ATX", Preco = 250.00m, Quantidade = 7 },
                new Produto { Id = 6, Nome = "HD 1TB", Preco = 400.00m, Quantidade = 6 },
                new Produto { Id = 7, Nome = "SSD 256GB", Preco = 300.00m, Quantidade = 10 },
                new Produto { Id = 8, Nome = "Placa Mãe", Preco = 800.00m, Quantidade = 4 },
                new Produto { Id = 9, Nome = "Processador", Preco = 1500.00m, Quantidade = 3 },
                new Produto { Id = 10, Nome = "Memória RAM 8GB", Preco = 200.00m, Quantidade = 12 }
            );
        }
    }
}