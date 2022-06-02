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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetBlogListByUser(int id)
        {
            return _blogDal.GetListWithEntities(x => x.UserId== id);
        }

        public List<Blog> GetBlogListWithEntities()
        {
            return _blogDal.GetListWithEntities();
        }

        public List<Blog> Get3HighRatingBlogList()
        {
            return _blogDal.GetListWithEntities().OrderByDescending(x=>x.BlogRating).Take(3).ToList();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetBlogByIdWithEntities(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetLast3Blogs()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public void TAdd(Blog obj)
        {
            obj.BlogStatus = true;
            obj.BlogCreateDate = DateTime.Now;
            _blogDal.Insert(obj);
        }

        public void TDelete(Blog obj)
        {
            obj.BlogStatus = false;
            _blogDal.Update(obj);
        }

        public void TUpdate(Blog obj)
        {
            _blogDal.Update(obj);
        }
    }
}
