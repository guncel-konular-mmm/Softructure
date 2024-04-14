using Soft.Core.DataAccess.EntityFramework;
using Soft.DataAccessLayer.Abstract;
using Soft.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product , Context>, IProductDal
    {
    }
}
