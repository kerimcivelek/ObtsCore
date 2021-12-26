
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Operation : IEntity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int FirstKm { get; set; }
        public int LastKm { get; set; }
        public int PeriodKm { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int OperationTypeId { get; set; }
        public List<OperationDetail> OperationDetails { get; set; }
    }
}
