
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer : IEntity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Plaka { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gsm { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? UserId { get; set; }
       
        
    }
}
