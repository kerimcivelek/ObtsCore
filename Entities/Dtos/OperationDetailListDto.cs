using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class OperationDetailListDto :  IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string ExternalProduct { get; set; }
        public string Note { get; set; }
        public int CustomerId { get; set; }
    }
}
