using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class LoanInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MaxTotalModel> MaxTotal { get; set; }
        public Boolean Compound { get; set; }
        public string Nots { get; set; }

        public class MaxTotalModel
        {
            public int Money { get; set; }
            public int Period { get; set; }
            public double Tax { get; set; }
            public string Nots { get; set; }
        }
    }

   
}
