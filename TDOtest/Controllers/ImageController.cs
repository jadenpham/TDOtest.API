using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDOtest.Models;
using TDOtest.Repositories;

namespace TDOtest.Controllers
{
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageRepository _imageRepo;
        public ImageController(IImageRepository imageRepo)
        {
            //constructor to inject dependency
            this._imageRepo = imageRepo;
        }

        //create method that return list of objects (6 items)
        //ImageID guid, ImageDescription varchar(50), ImagePath(varchar200)
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetImageList()
        {


            var imageList = new List<Image>();
            imageList = await _imageRepo.GetAllImagesAsync();
            #region
            //var imageObjA = new Image()
            //{
            //    ImageId = new Guid(),
            //    ImageDescription = "ImageA",
            //    ImagePath = "c:/Jaden/Images/ImageA",
            //};
            //var imageObjB = new Image()
            //{
            //    ImageId = new Guid(),
            //    ImageDescription = "ImageB",
            //    ImagePath = "c:/Jaden/Images/ImageB",
            //};
            //var imageObjC = new Image()
            //{
            //    ImageId = new Guid(),
            //    ImageDescription = "ImageC",
            //    ImagePath = "c:/Jaden/Images/ImageC",
            //};
            //imageList.Add(imageObjA);
            //imageList.Add(imageObjB);
            //imageList.Add(imageObjC);
            #endregion
            return Ok(imageList);
        }
    }
}
