using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspblog.business.Abstarct;
using aspblog.data.EntityFrameWork;
using aspblog.entity.Concrate;

namespace aspblog.business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efcategoryrepository;
        public CategoryManager()
        {
            efcategoryrepository = new EfCategoryRepository();
        }

        public void CategoryUpdate(Category category)
        {
            efcategoryrepository.Update(category);
        }
    }
}    