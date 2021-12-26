using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class VehicleBrand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
    }
}
