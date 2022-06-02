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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment GetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetCommentsWithUser(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetListAll();
        }

        public void TAdd(Comment obj)
        {
            _commentDal.Insert(obj);
        }

        public void TDelete(Comment obj)
        {
            obj.CommentStatus = false;
        }

        public void TUpdate(Comment obj)
        {
            _commentDal.Update(obj);
        }
    }
}
