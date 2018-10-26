using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AspNetMvc5.Models;

namespace AspNetMvc5.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        public ICategoriesRepository Categories { get; }
        private AspNetMvc5Context _context;

        public UnitOfWork(AspNetMvc5Context context)
        {
            _context = context;

            Categories = new CategoriesRepository(_context);
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}