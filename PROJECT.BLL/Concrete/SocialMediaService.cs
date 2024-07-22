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

    public class SocialMediaService : ISocialMediaService
    {
        private readonly ISocialMedaiDal _socialMediaDal;

        public SocialMediaService(ISocialMedaiDal socialMediaDal)
        {
            this._socialMediaDal=socialMediaDal;
        }

        public void TInsert(SocialMedia entity)
        {
           this._socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
         this._socialMediaDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._socialMediaDal.Delete(Id);
        }

        public List<SocialMedia> TGetAll()
        {
            return this._socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return this._socialMediaDal.GetById(id);
        }
    }
}
