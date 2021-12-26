using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Note : IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime RegisterDate { get; set; }
        public int CustomerId { get; set; }
    }
}
