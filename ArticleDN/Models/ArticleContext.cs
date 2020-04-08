using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDN.Models
{
    public class ArticleContext : IdentityDbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) :
            base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Menu> Menus { get; set; }
    }

}
