using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
  public  class DashboardDto : IDto
    {
        public string OperationTypeName { get; set; }
        public int totalOperation { get; set; }
        public decimal totalPrice { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
       



    }
}
