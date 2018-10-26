using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using AspNetMvc5.Models;

namespace AspNetMvc5.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly AspNetMvc5Context _context;
        private DbSet<T> db;
        public Repository(AspNetMvc5Context context)
        {
            _context = context;
            db = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await db.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            return await db.Where(predicate).ToListAsync();
        }

        public async Task<T> FindOne(Expression<Func<T, bool>> predicate)
        {
            return await db.SingleOrDefaultAsync(predicate);
        }

        public async Task<T> Find(int id)
        {
            return await db.FindAsync(id);
        }

        public void Add(T t)
        {
            db.Add(t);
        }

        public void Update(T t)
        {
            db.AddOrUpdate(t);
        }

        public void Delete(T t)
        {
            db.Remove(t);
        }
    }
}