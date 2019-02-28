using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class OrderTracking
    {
        [Key]
        public int OrderTrackingID { get; set; }

        [ForeignKey("Orders")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int OrderID { get; set; }
        public Orders Orders { get; set; }

        [StringLength(60, ErrorMessage = "Longitud maxima de 60")]
        public String Address { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String City { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Country { get; set; }
    }
}