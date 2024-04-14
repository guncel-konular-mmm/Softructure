using Soft.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.EntityLayer.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDesc { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
