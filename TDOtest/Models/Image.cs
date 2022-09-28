using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TDOtest.Models
{
    public class Image
    {
        [Required]
        public Guid ImageId { get; set; }

        [StringLength(50)]
        public string ImageDescription { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }
    }
}
