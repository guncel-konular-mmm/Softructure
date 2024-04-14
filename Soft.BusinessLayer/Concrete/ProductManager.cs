using Soft.BusinessLayer.Abstract;
using Soft.DataAccessLayer.Abstract;
using Soft.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
