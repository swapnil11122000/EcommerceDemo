using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EProject.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Catid { get; set; }
        [Required]
        public string Catname { get; set; }
    }
}
