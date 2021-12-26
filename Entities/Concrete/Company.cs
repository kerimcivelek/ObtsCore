using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Owner { get; set; }
        public string Gsm { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Category> Categories { get; set; }
    }
}
