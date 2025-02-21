using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Db
{
    public class KitapContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = bookstore.db;");
        }
    }
}
