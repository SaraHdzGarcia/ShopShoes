using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Subscriptions
    {
        [Key]
        public int SubscriptionID { get; set; }

        [StringLength(70,ErrorMessage ="Valor maximo de 70")]
        public string Email { get; set; }
    }
}