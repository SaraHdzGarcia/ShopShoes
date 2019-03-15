using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(60, ErrorMessage ="Valor máximo de 60")]
        public string Name { get; set; }

        [StringLength(70,ErrorMessage ="Valor maximo de 70")]
        public string Email { get; set; }

        [StringLength(24,ErrorMessage ="Valor maximo de 24")]
        public string Telephone { get; set; }

        [DataType(DataType.Text)]
        public string Message { get; set; }
    }
}