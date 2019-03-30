using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class CarritoModel
    {
        [Display(Name ="Descripcion")]
        public String Description { get; set; }

        [Display(Name = "Codigo")]
        public String BarCode { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        
        [DataType(DataType.Currency)]
        [Display(Name = "Precio")]
        public Decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name ="Total")]
        public Decimal Total { get; set; }
    }
}