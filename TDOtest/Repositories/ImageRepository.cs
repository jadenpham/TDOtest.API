using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDOtest.Models;

namespace TDOtest.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ImageDbContext context;
        public ImageRepository(ImageDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Image>> GetAllImagesAsync()
        {
            return await context.Image.ToListAsync();
        }
    }
}
