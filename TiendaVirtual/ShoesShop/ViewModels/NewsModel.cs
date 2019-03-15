using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class NewsModel
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Email { get; set; }
    }
}