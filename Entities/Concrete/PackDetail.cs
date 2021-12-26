using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class PackDetail : IEntity
    {
        public int Id { get; set; }
        public int PackId { get; set; }
        public Pack Pack { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
    }
}
