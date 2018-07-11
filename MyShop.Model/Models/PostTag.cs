using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PosID { get; set; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("PosID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
