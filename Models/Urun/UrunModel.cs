using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class UrunModel
{
    [Required(ErrorMessage = "Ürün adı boş bırakılamaz.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Ürün adı 3-50 karakter arasında olmalıdır.")]
    [Display(Name = "Ürün Adı")]
    public string UrunAdi { get; set; } = null!;

    [Required(ErrorMessage = "Ürün fiyatı boş bırakılamaz.")]
    [Range(0, double.MaxValue, ErrorMessage = "Ürün fiyatı 0'dan büyük olmalıdır.")]
    [Display(Name = "Ürün Fiyat")]
    public double? Fiyat { get; set; }

    [Required(ErrorMessage = "Ürün resmi boş bırakılamaz.")]
    [Display(Name = "Ürün Resmi")]
    public IFormFile? Resim { get; set; }

    [Required(ErrorMessage = "Ürün açıklaması boş bırakılamaz.")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Ürün açıklaması 3-500 karakter arasında olmalıdır.")]
    public string? Aciklama { get; set; }

    [Required(ErrorMessage = "Ürün aktiflik durumu boş bırakılamaz.")]
    public bool Aktif { get; set; }

    [Required(ErrorMessage = "Ürün anasayfa görünümü boş bırakılamaz.")]
    public bool Anasayfa { get; set; }

    [Required(ErrorMessage = "Ürün kategori boş bırakılamaz.")]
    public int? KategoriId { get; set; }
}