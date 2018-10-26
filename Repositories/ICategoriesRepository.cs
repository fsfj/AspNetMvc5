using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using AspNetMvc5.Models;

namespace AspNetMvc5.Repositories
{
    public interface ICategoriesRepository : IRepository<Category>
    {
    }
}
