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
        
        [StringLength(50,ErrorMessage ="Longitud maxima de 50")]
        public String Statuss { get; set; }
    }
}