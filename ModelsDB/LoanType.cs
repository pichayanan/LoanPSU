using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.ModelsDB
{
    public partial class LoanType
    {
        public byte? LoanParentId { get; set; }
        public string LoanParentName { get; set; }
        public int LoanTypeId { get; set; }
        public string LoanTypeName { get; set; }
        public int LoanMaxAmount { get; set; }
        public decimal? LoanInterate { get; set; }
        public byte? LoanPeriod { get; set; }
        public int Active { get; set; }
        public string Remark { get; set; }
    }
}
