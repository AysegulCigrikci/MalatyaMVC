using System;
using System.Collections.Generic;

namespace MalatyaMVC.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
