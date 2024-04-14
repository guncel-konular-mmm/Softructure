using Soft.EntityLayer.Concrete;
using Soft.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.DataAccessLayer.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}

