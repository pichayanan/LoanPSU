using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.ModelsDB;

namespace BlazorApp.Pages
{
    public partial class ApplyLoan
    {
        ApplyLoanModel ModelApplyLoan;
        List<VLoanStaffDetail> guarantorList;
        List<LoanType> LoanTypeList;
        public LoanType Model { get; set; }

        [Parameter]
        public decimal LoadID { get; set; } = 0;

        protected override void OnInitialized()
        {
            ModelApplyLoan = new ApplyLoanModel();
            Model = new LoanType();
            guarantorList = new List<VLoanStaffDetail>();

            SetData();

            if (LoadID != 0)
            {
                Model = _context.LoanTypes.Where(c => c.LoanTypeId == LoadID).FirstOrDefault();
                ModelApplyLoan.LoanTypeID = Model.LoanTypeId;
                ModelApplyLoan.Period = (int)Model.LoanPeriod;
                ModelApplyLoan.LoanMaxAmount = Model.LoanMaxAmount;
            }
            else {
                ModelApplyLoan.LoanTypeID = 0;
                ModelApplyLoan.LoanMaxAmount = 0;
                ModelApplyLoan.Period = 0;
            }
            ModelApplyLoan.Guarantor = "";
        }

        public void SetData()
        {
            LoanTypeList = new List<LoanType>();
            LoanTypeList = _context.LoanTypes.Where(c => c.Active == 1).ToList<LoanType>();
            LoanTypeList.Insert(0, new LoanType() { LoanTypeId = 0, LoanTypeName = "---กรุณาระบุ---" });
        }
    }
}
