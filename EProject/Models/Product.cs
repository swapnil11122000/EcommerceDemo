﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EProject.Models
{
    [Table("Products")]

    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Pid { get; set; }
        [Required]
        public string Pname { get; set; }
        [Required]
       
        public int Catid { get; set; }
        [NotMapped]
        public string  Catname { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Img { get; set; }
    }
}
