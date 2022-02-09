using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspblog.entity.Concrate;
using Microsoft.EntityFrameworkCore;

namespace aspblog.data.Concrate
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FARUK\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        } 
        public DbSet<About> Abouts {get;set;}
        public DbSet<Blog> Blogs {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Comment> Comments {get;set;}
        public DbSet<Contact> Contacts {get;set;}
        public DbSet<Writer> Writers {get;set;}
    }
}