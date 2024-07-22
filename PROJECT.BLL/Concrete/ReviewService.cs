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

    public class ReviewService : IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewService(IReviewDal reviewDal)
        {
            this._reviewDal=reviewDal;
        }


        public void TInsert(Review entity)
        {
            this._reviewDal.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
           this._reviewDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._reviewDal.Delete(Id);
        }

        public List<Review> TGetAll()
        {
            return this._reviewDal.GetAll();
        }

        public Review TGetById(int id)
        {
            return this._reviewDal.GetById(id);
        }
    }
}
