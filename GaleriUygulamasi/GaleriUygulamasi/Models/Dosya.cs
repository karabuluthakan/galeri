//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GaleriUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dosya
    {
        public int Id { get; set; }
        public byte[] Deger { get; set; }
        public string DosyaAdi { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string DosyaTipi { get; set; }
        public string DosyaBoyutu { get; set; }
        public string BoyutKisaltma { get; set; }
        public string Ikon { get; set; }
        public string Renk { get; set; }
        public string Resim { get; set; }
        public System.DateTime KayitTarihi { get; set; }
    }
}
