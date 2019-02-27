using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customers")]
        [StringLength(5, ErrorMessage = "Longitud maxima de 5")]
        public String UserID { get; set; }
        public Userss Userss { get; set; }

        [ForeignKey("Employees")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int EmployeeID { get; set; }
        public Employees Employees { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShippedDate { get; set; }

        [Required(ErrorMessage ="Campo obligaotorio")]
        [Range(0,int.MaxValue,ErrorMessage ="Acepta valores enteros")]
        public int TotalProduct { get; set; }
    }
}