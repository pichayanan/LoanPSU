using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class GuarantorPeople
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public Boolean MarriageStatus { get; set; }
        public string MarriageName { get; set; }
        public Boolean BabyStatus { get; set; }
        public string BabyName { get; set; }
    }
}
