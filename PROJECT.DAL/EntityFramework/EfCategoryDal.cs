using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.EntityFramework
{
    using PROJECT.DAL.Abstract;
    using PROJECT.DAL.Context;
    using PROJECT.DAL.Repositories;
    using PROJECT.ENTITIES.Concrete;

    public class EfCategoryDal : GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(MyContext context)
            : base(context)
        {
        }
    }
}
