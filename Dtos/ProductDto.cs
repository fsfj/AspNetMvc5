using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc5.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
    }
}