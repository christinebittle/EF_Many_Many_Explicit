using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5204_mypassion_project_n1010101010.Models
{
    public class ProductxCategory
    {
        [Key]
        public int ProductxCategoryID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product {get; set;}

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Extra field added to bridging table
        public bool Primary { get; set; }
    }
}