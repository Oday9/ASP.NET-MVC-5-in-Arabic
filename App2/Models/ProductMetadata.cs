using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App2.Models
{
    [MetadataType(typeof(Product.Metadata))]
    public partial class Product
    {
        sealed class Metadata
        {
            public System.Guid ProductId { get; set; }
            [Display(Name ="Product Name")]
            [Required]
            [StringLength(5)]
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}