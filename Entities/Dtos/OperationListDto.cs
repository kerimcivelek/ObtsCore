﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class OperationListDto :  IDto
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public int FirstKm { get; set; }
        public int LastKm { get; set; }
        public int PeriodKm { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
        public string OperationName { get; set; }
    }
}
