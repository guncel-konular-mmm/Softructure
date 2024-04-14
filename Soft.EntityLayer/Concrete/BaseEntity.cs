using Soft.EntityLayer.Abstract;
using Soft.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ortak, yani genel propertyler BaseEntity’den devralınır.
namespace Soft.EntityLayer.Concrete
{
    public class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public GlobalEnums Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = GlobalEnums.Inserted;
        }
    }
}
