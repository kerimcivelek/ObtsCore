using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class OperationDto : IDto
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? CustomerId { get; set; }
        public int FirstKm { get; set; }
        public int LastKm { get; set; }
        public int PeriodKm { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }
        public Guid Key { get; set; }
        public int OperationTypeId { get; set; }
        
    }
}
