using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspblog.entity.Concrate;

namespace aspblog.business.Abstarct
{
    public interface ICategoryService
    {
        void CategoryUpdate(Category category);
    }
}