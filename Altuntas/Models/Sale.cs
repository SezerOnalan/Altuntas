using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Altuntas.Models
{
    public class Sale
    {
    public int Id { get; set; }
    [Display(Name = "Satıcı")]
    public int SellerId { get; set; }
    [Display(Name = "Satıcı")]
    [ForeignKey("SellerId")]
    public Seller Seller { get; set; }
    [Display(Name = "Alıcı")]
    public int BuyerId { get; set; }
    [Display(Name = "Alıcı")]
    [ForeignKey("BuyerId")]
    public Buyer Buyer { get; set; }
    [Display(Name = "Adres")]
    [StringLength(4000)]
    public string Adress { get; set; }
    [Display(Name = "Model")]
    public string Model { get; set; }
    [Display(Name = "Genişlik")]
    public double Width { get; set; }
    [Display(Name = "Yükseklik")]
    public double? Height { get; set; }
    [Display(Name = "Uzunluk")]
    public double? Length { get; set; }
    [Display(Name = "Aldığı Kalıplar")]
    [StringLength(4000)]
    public string ReceivedForms { get; set; }
    [Display(Name = "Garanti Bitiş Tarihi")]
    public DateTime? WarrantyEndDate { get; set; }
    [Display(Name = "Fatura Bedeli")]
    public decimal? invoicePrice { get; set; }
    [Display(Name = "Bizim Satış Fiyatı")]
    public decimal OurSalePrice { get; set; }
    [Display(Name = "Komisyon")]
    public decimal? Commission { get; set; }
    [Display(Name = "Extra Kalıp Fiyatı")]
    [StringLength(4000)]
    public string ExtraFormPrice { get; set; }
    [Display(Name = "Açıklama")]
    public string Description { get; set; }
    [Display(Name = "Oluşturulma Tarihi")]
    public DateTime CreateDate { get; set; }
    [Display(Name = "Oluşturan Kullanıcı")]
    public string CreateBy { get; set; }
    [Display(Name = "Güncelleme Tarihi")]
    public DateTime UpdateDate { get; set; }
    [Display(Name = "Güncelleştiren Kullanıcı")]
    public string UpdateBy { get; set; }
    }
}
