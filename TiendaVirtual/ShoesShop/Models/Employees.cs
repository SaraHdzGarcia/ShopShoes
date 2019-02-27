﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud maxima de 20")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String FirstName { get; set; }

        [StringLength(60, ErrorMessage = "Longitud maxima de 60")]
        public String Address { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String City { get; set; }

        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Country { get; set; }

        [StringLength(24, ErrorMessage = "Longitud maxima de 24")]
        public String Telephone { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        [StringLength(50,ErrorMessage ="Longitud maxima de 50")]
        public String UserName { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [StringLength(50,ErrorMessage ="Longitud maxima de 50")]
        public String Password { get; set; }

        [ForeignKey("Userss")]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int UserID { get; set; }
        public Userss Userss { get; set; }
    }
}