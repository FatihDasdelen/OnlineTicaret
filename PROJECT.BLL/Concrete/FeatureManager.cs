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

    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            this._featureDal=featureDal;
        }

        public void TInsert(Feature entity)
        {
           this._featureDal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
           this._featureDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._featureDal.Delete(Id);
        }

        public List<Feature> TGetAll()
        {
            return this._featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
            return this._featureDal.GetById(id);
        }
    }
}
