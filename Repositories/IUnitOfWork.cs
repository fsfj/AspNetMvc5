using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc5.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriesRepository Categories { get; }
        Task CompleteAsync();
    }
}
