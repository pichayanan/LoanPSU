using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ApplyLoanData
    {
        public int LoanTypeID { get; set; }
        public int Money { get; set; }
        public int Period { get; set; }
        public string Guarantor { get; set; }
    }
}
