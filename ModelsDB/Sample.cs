using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.ModelsDB
{
    public partial class Sample
    {
        public decimal? Id { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
