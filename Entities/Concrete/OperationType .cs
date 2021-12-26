using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OperationType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        //public List<Operation> Operations { get; set; }
        public List<OperationDetail> OperationDetails { get; set; }
    }
}
