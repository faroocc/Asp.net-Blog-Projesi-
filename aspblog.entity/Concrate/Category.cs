using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspblog.entity.Concrate
{
    public class Category
    {
        [Key]
        //erişim belirleyici türü -değişken türü
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Blog> Blog { get; set; }
    }
}