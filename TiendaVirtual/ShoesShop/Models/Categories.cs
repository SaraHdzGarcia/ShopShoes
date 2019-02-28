using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(30,ErrorMessage = "Longitud maxima de 30")]
        public String CategoryName { get; set; }


        [StringLength(40, ErrorMessage = "Longitud maxima de 40")]
        public String Description { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}