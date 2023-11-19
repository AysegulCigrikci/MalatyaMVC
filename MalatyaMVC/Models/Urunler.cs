using System;
using System.Collections.Generic;

namespace MalatyaMVC.Models
{
    public partial class Urunler
    {
        public int id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ResimYol { get; set; }
        public string Fiyat { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> ResimID { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
