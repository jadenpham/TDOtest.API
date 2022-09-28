using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDOtest.Models;

namespace TDOtest.Repositories
{
    public interface IImageRepository
    {
        Task<List<Image>> GetAllImagesAsync();
    }
}
