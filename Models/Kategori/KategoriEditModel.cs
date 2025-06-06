using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class KategoriEditModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Kategori adı 3-50 karakter arasında olmalıdır.")]
    [Display(Name = "Kategori Adı")]
    public string KategoriAdi { get; set; } = null!;
    [Required(ErrorMessage = "URL boş bırakılamaz.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "URL 3-50 karakter arasında olmalıdır.")]
    [RegularExpression(@"^[a-z0-9-]+$", ErrorMessage = "URL yalnızca küçük harf, sayı ve tire içerebilir.")]
    [Display(Name = "URL")]
    public string Url { get; set; } = null!;
}