using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_Task.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Desc { get; set; }
    }
}