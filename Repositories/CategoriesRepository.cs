using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvc5.Models;

namespace AspNetMvc5.Repositories
{
    public class CategoriesRepository: Repository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(AspNetMvc5Context context) 
            : base(context)
        {
        }
    }
}