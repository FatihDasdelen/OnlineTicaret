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

    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this._aboutDal=aboutDal;
        }


        public void TInsert(About entity)
        {
            this._aboutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
           this._aboutDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._aboutDal.Delete(Id);
        }

        public List<About> TGetAll()
        {
            return this._aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
            return this._aboutDal.GetById(id);
        }
    }
}
