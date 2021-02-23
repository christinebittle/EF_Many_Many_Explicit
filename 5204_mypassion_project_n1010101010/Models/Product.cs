using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5204_mypassion_project_n1010101010.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        //many to many relationship configured in bridging model ProductxCategory.cs
    }


    public class ProductDto
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
   
}