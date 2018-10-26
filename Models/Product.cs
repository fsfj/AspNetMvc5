using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvc5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int Qty { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}