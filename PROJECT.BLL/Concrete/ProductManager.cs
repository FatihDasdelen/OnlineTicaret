using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.Concrete
{
    using PROJECT.BLL.Abstract;
    using PROJECT.DAL.Abstract;
    using PROJECT.ENTITIES.Concrete;

    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            this._productDal= productDal;
        }


        public void TInsert(Product entity)
        {
           this._productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            this._productDal.Update(entity);
        }

        public void TDelete(int Id)
        {
          this._productDal.Delete(Id);
        }

        public List<Product> TGetAll()
        {
            return this._productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return this._productDal.GetById(id);
        }
    }
}
