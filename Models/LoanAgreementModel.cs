using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class LoanAgreementModel
    {
        public String SingingDate { get; set; }
        public String LoanType { get; set; }
        public int LoanStatus { get; set; }
        public int NoLoan { get; set; }
        public int LoanAmout { get; set; }
        public String DateSubmit { get; set; }
        public int TotalAmout { get; set; }
        public String Note { get; set; }
        public int PlaymentStatus { get; set; }
    }
}
