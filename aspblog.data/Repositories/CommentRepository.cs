using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspblog.data.Abstract;
using aspblog.entity.Concrate;

namespace aspblog.data.Repositories
{
    public class CommentRepository : IGeneric<Comment>
    {
        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}