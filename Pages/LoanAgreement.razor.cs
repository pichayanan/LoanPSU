using BlazorApp.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class LoanAgreement
    {
        List<LoanAgreementModel> listAgreement;
        string jsonLoanAgreement = "wwwroot/json/LoanAgreement.json";
        string Message = "แสดงเฉพาะที่ยังไม่สิ้นสุดสัญญา";
        Boolean LoanCheckbook = false;
        string titleStatus = "";
        string detailNote = "";
        string dataDefault = "-";

        protected override void OnInitialized()
        {
            listAgreement = new List<LoanAgreementModel>();
            string jsonString = File.ReadAllText(jsonLoanAgreement);
            listAgreement = JsonConvert.DeserializeObject<List<LoanAgreementModel>>(jsonString);
        }

        public void UploadPayment(LoanAgreementModel agreement)
        {
            if (agreement.LoanStatus == 4 || agreement.LoanStatus == 5 || agreement.LoanStatus == 6)
            {
                NavigationManager.NavigateTo("/AgreementDetail");
            }
        }

        public async Task CheckboxSwitch()
        {
            var interopResult = await JS.InvokeAsync<Boolean>("checkboxSwitch");

            if (interopResult == true)
            {
                Message = "แสดงสัญญาทั้งหมด";
            }
            else
            {
                Message = "แสดงเฉพาะที่ยังไม่สิ้นสุดสัญญา";
            }
            LoanCheckbook = interopResult;
        }
    }
}
