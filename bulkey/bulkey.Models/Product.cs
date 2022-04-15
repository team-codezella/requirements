
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkey.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]

        public string Author { get; set; }


       

        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set; }

        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; }


        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryRepositeryId { get; set; }
        [ValidateNever]
        [Display(Name ="Category" )]
        public CategoryRepositery CategoryRepositery { get;set;}

        [Required]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        [Display(Name ="cover type")]
        public CoverType CoverType { get; set; }

    }
}
