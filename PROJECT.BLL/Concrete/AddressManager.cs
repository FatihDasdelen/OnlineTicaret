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

    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            this._addressDal = addressDal;
        }


        public void TInsert(Address entity)
        {
            this._addressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            this._addressDal.Update(entity);
        }

        public void TDelete(int Id)
        {
            this._addressDal.Delete(Id);
        }

        public List<Address> TGetAll()
        {
            return this._addressDal.GetAll();
        }

        public Address TGetById(int id)
        {
            return this._addressDal.GetById(id);
        }
    }
}
