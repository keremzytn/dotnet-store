using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<Kategori> Kategoriler { get; set; }
    public DbSet<Slider> Sliderlar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider>
            {
                new Slider{Id=1, Resim="slider-1.jpeg" },
                new Slider{Id=2, Resim="slider-2.jpeg" },
                new Slider{Id=3, Resim="slider-3.jpeg" },
            }
        );

        modelBuilder.Entity<Kategori>().HasData(
            new List<Kategori>
            {
                new Kategori{Id=1, KategoriAdi="Telefon", Url="telefon"},
                new Kategori{Id=2, KategoriAdi="Elektronik", Url="elektronik"},
                new Kategori{Id=3, KategoriAdi="Beyaz Eşya", Url="beyaz-esya"},
                new Kategori{Id=4, KategoriAdi="Giyim", Url="giyim"},
                new Kategori{Id=5, KategoriAdi="Kozmetik", Url="kozmetik"},
                new Kategori{Id=6, KategoriAdi="Kategori 1", Url="kategori-1"},
                new Kategori{Id=7, KategoriAdi="Kategori 2", Url="kategori-2"},
                new Kategori{Id=8, KategoriAdi="Kategori 3", Url="kategori-3"},
                new Kategori{Id=9, KategoriAdi="Kategori 4", Url="kategori-4"},
                new Kategori{Id=10, KategoriAdi="Kategori 5", Url="kategori-5"},

            }
        );

        modelBuilder.Entity<Urun>().HasData(
            new List<Urun>()
            {
                new Urun() { Id = 1, UrunAdi="Apple Watch 7", Fiyat=10000, Aktif=false, Resim="1.jpeg", Anasayfa=true,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=1},
                new Urun() { Id = 2, UrunAdi="Apple Watch 8", Fiyat=20000, Aktif=true, Resim="2.jpeg", Anasayfa=true,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=2},
                new Urun() { Id = 3, UrunAdi="Apple Watch 9", Fiyat=30000, Aktif=true, Resim="3.jpeg", Anasayfa=false,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=3},
                new Urun() { Id = 4, UrunAdi="Apple Watch 10", Fiyat=40000, Aktif=false, Resim="4.jpeg", Anasayfa=true,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=4},
                new Urun() { Id = 5, UrunAdi="Apple Watch 11", Fiyat=50000, Aktif=true, Resim="5.jpeg", Anasayfa=true,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=5},
                new Urun() { Id = 6, UrunAdi="Apple Watch 12", Fiyat=60000, Aktif=true, Resim="6.jpeg", Anasayfa=true,Aciklama="Lorem ipsum dolor sit amet.",KategoriId=1},
            }
        );
    }
}
