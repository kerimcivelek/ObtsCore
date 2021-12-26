using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public List<OperationDetail> OperationDetails { get; set; }
        public List<Product> Products { get; set; }

    }
}
