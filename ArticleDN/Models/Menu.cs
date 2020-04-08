using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDN.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string MenuName { get; set; }
    }
}
