using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Models
{
    public class ApplyLoanModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "กรุณาเลือกประเภทการกู้")]
        public int LoanTypeID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "กรุณากรอกกำนวณเงินกู้")]
        public decimal LoanMaxAmount { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "กรุณากรอกกำนวณงวดในการกู้")]
        public int Period { get; set; }

        [Required(ErrorMessage = "กรุณากรอกชื่อผู้ค้ำ")]
        public string Guarantor { get; set; }
        public string GuarantorId { get; set; }
    }
}
