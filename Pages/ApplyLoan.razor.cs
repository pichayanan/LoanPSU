using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class ApplyLoan
    {
        ApplyLoanModel ModelApplyLoan;
        List<SelectLoanType> LoanTypeList;
        protected override void OnInitialized()
        {
            LoanTypeList = new List<SelectLoanType>()
            {
            new SelectLoanType{ TypeId=0, Title="---กรุณาระบุ---"},
            new SelectLoanType{ TypeId=1, Title="1"},
            new SelectLoanType{ TypeId=2, Title="2"},
            new SelectLoanType{ TypeId=3, Title="3"},
            new SelectLoanType{ TypeId=4, Title="4"},
            new SelectLoanType{ TypeId=5, Title="5"},
            new SelectLoanType{ TypeId=6, Title="6"},
            new SelectLoanType{ TypeId=7, Title="7"},
            new SelectLoanType{ TypeId=8, Title="8"},
            new SelectLoanType{ TypeId=9, Title="9"},
            new SelectLoanType{ TypeId=10,Title="10"},
            new SelectLoanType{ TypeId=11,Title="11"},
            new SelectLoanType{ TypeId=12,Title="12"},
            };

            ModelApplyLoan = new ApplyLoanModel();
            ModelApplyLoan.LoanTypeID = 0;
            ModelApplyLoan.Money = 0;
            ModelApplyLoan.Period = 0;
            ModelApplyLoan.Guarantor = "";
        }


        public class SelectLoanType
        {
            public int TypeId { get; set; }
            public string Title { get; set; }
        }
    }
}
