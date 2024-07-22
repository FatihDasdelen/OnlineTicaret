using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Repositories
{
    using PROJECT.DAL.Abstract;
    using PROJECT.DAL.Context;

    public class GenericRepository<T>:IGenericDal<T> where T: class
    {
        private readonly MyContext _context;

        public GenericRepository(MyContext context)
        {
            _context = context;
            
        }


        public void Insert(T entity)
        {
            this._context.Set<T>().Add(entity);
            this._context.SaveChanges();
        }

        public void Update(T entity)
        {
            this._context.Set<T>().Update(entity);
            this._context.SaveChanges();
        }

        public void Delete(int Id)
        {
            T value = this._context.Set<T>().Find(Id);
            this._context.Set<T>().Remove(value);
            this._context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return this._context.Set<T>().Find(id);
        }
    }
}
