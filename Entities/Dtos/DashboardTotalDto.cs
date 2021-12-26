using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class DashboardTotalDto
    {
        public int TotalCustomerThisMonth { get; set; }
        public int TotalCustomerThisDay { get; set; }
        public decimal TotalPriceThisMonth { get; set; }
        public decimal TotalPriceThisDay { get; set; }
    }
}
