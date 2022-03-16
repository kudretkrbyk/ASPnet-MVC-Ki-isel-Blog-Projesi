using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace okulodevMVC.Models.Siniflar
{
    public class yeni
    {
        [Key]
        public int ID { get; set; }
        public string ResimYolu { get; set; }
        public string ResimAlt { get; set; }
    }
}