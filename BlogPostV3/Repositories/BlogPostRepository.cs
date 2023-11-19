using BlogPostV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogPostV3.Repositories
{
    public class BlogPostRepository
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        public List<BlogPost> BlogPosts { get; set; }
        public BlogPostRepository() { 
        }

        public List<BlogPost> GetBlogPosts() {
            
            return db.blogPosts.Include(e=>e.Comentarios).ToList();
            
        }
    }
}