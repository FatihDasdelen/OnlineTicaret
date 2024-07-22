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

    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            this._sliderDal=sliderDal;
        }

        public void TInsert(Slider entity)
        {
            this._sliderDal.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
           this._sliderDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._sliderDal.Delete(Id);
        }

        public List<Slider> TGetAll()
        {
            return this._sliderDal.GetAll();

        }

        public Slider TGetById(int id)
        {
            return this._sliderDal.GetById(id);
        }
    }
}
