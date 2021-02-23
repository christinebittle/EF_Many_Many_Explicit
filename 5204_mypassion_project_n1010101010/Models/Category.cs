using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5204_mypassion_project_n1010101010.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        //many to many relationship configured in bridging model ProductxCategory.cs
    }

    public class CategoryDto
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}