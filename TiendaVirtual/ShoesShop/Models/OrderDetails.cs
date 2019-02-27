using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }

        [ForeignKey("Orders")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int OrderID { get; set; }
        public Orders Orders { get; set; }
        
        [ForeignKey("Products")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int ProductID { get; set; }
        public Products Products { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public Int16 Quantity { get; set; }
        
        [StringLength(30,ErrorMessage ="Longitud maxima de 30")]
        public String Color { get; set; }

        [StringLength(15,ErrorMessage ="Longitud maxima de 15")]
        public String Size { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Total { get; set; }
    }
}