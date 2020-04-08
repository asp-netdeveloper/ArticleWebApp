using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDN.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string ArticleName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string ArticleDetail { get; set; }
    }

}
