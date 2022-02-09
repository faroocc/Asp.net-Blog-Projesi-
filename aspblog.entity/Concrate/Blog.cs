using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspblog.entity.Concrate
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool BlogStatus { get; set; } 
        public int CategoryID { get; set; }
        public Category Category { get; set; } 
        public List<Comment> Comments { get; set; }  
    }
}