using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.ModelsDB
{
    public partial class TypeLoan
    {
        public decimal LoanTypeId { get; set; }
        public string LoanTypeName { get; set; }
        public decimal LoanParentId { get; set; }
        public string LoanParentName { get; set; }
        public decimal LoanMaxAmount { get; set; }
        public string LoanInterate { get; set; }
        public decimal LoanPeriod { get; set; }
        public decimal Active { get; set; }
        public string Remark { get; set; }
        public string File { get; set; }
    }
}
