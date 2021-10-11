using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.ModelsDB
{
    public partial class LoanType
    {
        public int LoanParentId { get; set; }
        public string LoanParentName { get; set; }
        public int LoanTypeId { get; set; }
        public string LoanTypeName { get; set; }
        public decimal LoanMaxAmount { get; set; }
        public decimal LoanInterest { get; set; }
        public int LoanPeriod { get; set; }
        public int Active { get; set; }
        public string Remark { get; set; }
    }
}
