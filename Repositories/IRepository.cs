using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Ajax.Utilities;

namespace AspNetMvc5.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> FindOne(Expression<Func<T, bool>> predicate);
        Task<T> Find(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);

    }
}
