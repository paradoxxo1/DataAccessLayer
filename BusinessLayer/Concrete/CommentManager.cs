using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class CommentManager : ICommentService
    {
        ICommentsDal _commentsdal;

        public CommentManager(ICommentsDal commentsdal)
        {
            _commentsdal = commentsdal;
        }

        public void TAdd(Comments entity)
        {
            _commentsdal .Add(entity);
        }

        public void TDelete(Comments entity)
        {
            _commentsdal.Delete(entity);
        }

        public List<Comments> TGetAll()
        {
            return _commentsdal.GetAll().ToList();

        }

        public Comments TGetId(int id)
        {
           return _commentsdal.GetId(id);
        }

        public void TUpdate(Comments entity)
        {
            _commentsdal.Update(entity);
        }
    }
}
