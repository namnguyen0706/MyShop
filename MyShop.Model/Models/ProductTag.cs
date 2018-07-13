using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar", Order =2)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]   
        public virtual Product Product { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
