using BlogWebAPI.ViewModels;
using BusinessLayer.Concrete;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        /// <summary>
        /// Get All Blogs
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get")]
        public string Get()
        {
            try
            {
                List<Blog> BlogList = bm.GetList().ToList();
                List<BlogAPIViewModel> ViewModelList = new List<BlogAPIViewModel>();
                foreach (var item in BlogList)
                {
                    BlogAPIViewModel viewModel = new BlogAPIViewModel
                    {
                        BlogContent = item.BlogContent,
                        BlogCreateDate = item.BlogCreateDate,
                        BlogID = item.BlogID,
                        BlogImage = item.BlogImage,
                        BlogRating = item.BlogRating,
                        BlogStatus = item.BlogStatus,
                        BlogThumbnailImage = item.BlogThumbnailImage,
                        BlogTitle = item.BlogTitle
                    };
                    ViewModelList.Add(viewModel);
                }
                return JsonConvert.SerializeObject(ViewModelList);
            }
            catch (Exception e)
            {
                return $"Something went Wrong! \n {e.Message}";
            }
        }

        /// <summary>
        /// Get a Blog By Id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public string Get(string id)
        {
            int Id;
            try
            {
                Id = Convert.ToInt32(id);
                Blog value = bm.GetByID(Id);
                BlogAPIViewModel viewModel = new BlogAPIViewModel
                {
                    BlogContent = value.BlogContent,
                    BlogCreateDate = value.BlogCreateDate,
                    BlogID = value.BlogID,
                    BlogImage = value.BlogImage,
                    BlogRating = value.BlogRating,
                    BlogStatus = value.BlogStatus,
                    BlogThumbnailImage = value.BlogThumbnailImage,
                    BlogTitle = value.BlogTitle
                };
                return JsonConvert.SerializeObject(viewModel);
            }
            catch (Exception e)
            {
                return $"Wrong value! \n {e.Message}";
            }
        }

        ///// <summary>
        ///// Create a Hotel
        ///// </summary>
        ///// <param name="hotel"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public Hotel Post([FromBody] Hotel hotel)
        //{
        //    return _hotelService.CreateHotel(hotel);
        //}


        ///// <summary>
        ///// Update the Hotel
        ///// </summary>
        ///// <param name="hotel"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public Hotel Put([FromBody] Hotel hotel)
        //{
        //    return _hotelService.UpdateHotel(hotel);
        //}


        ///// <summary>
        ///// Delete the Hotel
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete]
        //public int Delete(int id)
        //{
        //    _hotelService.DeleteHotel(id);
        //    return id;
        //}
    }
}
