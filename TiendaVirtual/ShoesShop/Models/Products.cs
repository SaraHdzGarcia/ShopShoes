using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(40, ErrorMessage = "Longitud maxima de 40")]
        public String ProductName { get; set; }

        [ForeignKey("Categories")]
        [Range(0, int.MaxValue, ErrorMessage = "Valores enteros")]
        public int CategoryID { get; set; }
        public Categories Categories { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Valores enteros")]
        public Int16 UnitsInStock { get; set; }

        //Cuanto lo voy a vender
        [DataType(DataType.Currency)]
        public Decimal ProducPrice { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public Int16 Quantity { get; set; }

        [StringLength(30, ErrorMessage = "Longitud maxima de 30")]
        public String Color { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Size { get; set; }
        
        [Required(ErrorMessage ="Campo obligatorio")]
        [Range(0,int.MaxValue,ErrorMessage ="Acepta valores enteros")]
        public int BarCode { get; set; }

        //Cuanto me costó
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public virtual ICollection<Shop>Shops { get; set; }



    }
}