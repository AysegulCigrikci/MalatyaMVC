using System;
using System.Collections.Generic;

namespace MalatyaMVC.Models
{
    public partial class Resimler
    {
        public int id { get; set; }
        public string ResimYolu { get; set; }
        public Nullable<int> ResimId { get; set; }
    }
}
