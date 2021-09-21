using BlazorApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class ApplyLoan
    {
        LoanTitleData loanTitleData;
        LoanDetailData loanDetailData;
        ApplyLoanModel ModelApplyLoan;
        List<SelectLoanType> LoanTypeList;
        string jsonLoanData = "wwwroot/json/LoanData.json";
        string jsonGuarantor = "wwwroot/json/Guarantor.json";

        List<GuarantorPeople> guarantorPeoples;
        List<GuarantorPeople> selectGuarantor;

        protected async override Task OnInitializedAsync()
        {
            ModelApplyLoan = new ApplyLoanModel();
            loanTitleData = new LoanTitleData();
            loanDetailData = new LoanDetailData();
            selectGuarantor = new List<GuarantorPeople>();

            setData();
            setGuarantor();

            var loanTitle = await sessionStorage.GetItemAsStringAsync("loanTitle");
            var loanDetail = await sessionStorage.GetItemAsStringAsync("loanDetail");
            if (loanTitle != null && loanDetail != null)
            {
                loanTitleData = await sessionStorage.GetItemAsync<LoanTitleData>("loanTitle");
                loanDetailData = await sessionStorage.GetItemAsync<LoanDetailData>("loanDetail");

                ModelApplyLoan.LoanTypeID = loanTitleData.Id;
                ModelApplyLoan.Money = loanDetailData.Money;
                ModelApplyLoan.Period = loanDetailData.Period;
            }
        }

        private void setData()
        {
            LoanTypeList = new List<SelectLoanType>();
            string jsonString = File.ReadAllText(jsonLoanData);
            LoanTypeList = JsonConvert.DeserializeObject<List<SelectLoanType>>(jsonString);
            LoanTypeList.Insert(0, new SelectLoanType() { Id = 0, Name = "---กรุณาระบุ---" });
            ModelApplyLoan.LoanTypeID = 0;
            ModelApplyLoan.Money = 0;
            ModelApplyLoan.Period = 0;
            ModelApplyLoan.Guarantor = "";
        }

        private void setGuarantor()
        {
            guarantorPeoples = new List<GuarantorPeople>();
            string jsonString = File.ReadAllText(jsonGuarantor);
            guarantorPeoples = JsonConvert.DeserializeObject<List<GuarantorPeople>>(jsonString);
        }

        public class SelectLoanType
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<LoanDetailData> MaxTotal { get; set; }
        }

        public class LoanTitleData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Boolean Compound { get; set; }
            public string Nots { get; set; }
        }

        public class LoanDetailData
        {
            public int Money { get; set; }
            public int Period { get; set; }
            public double Tax { get; set; }
            public string Nots { get; set; }
        }
    }
}
