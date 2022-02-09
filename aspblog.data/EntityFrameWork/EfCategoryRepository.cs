using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspblog.data.Abstract;
using aspblog.data.Repositories;
using aspblog.entity.Concrate;

namespace aspblog.data.EntityFrameWork
{
    public class EfCategoryRepository:GenericRepository<Category>, ICategory
    {
        
    }
}