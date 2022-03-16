using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace okulodevMVC.Models.Siniflar
{
    public class ForImage
    {
        [Key]
        public int ID { get; set; }
        public string ImgUrl { get; set; }
        public string ImgDetail { get; set; }
    }
}