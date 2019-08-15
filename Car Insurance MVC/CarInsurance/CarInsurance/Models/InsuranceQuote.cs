using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class InsuranceQuote
    {
        public int age { get; set; }
        public string carMake { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string EmailAddress { get; internal set; }
        public int carYear { get; internal set; }
        public bool Dui { get; internal set; }
        public bool fullCoverage { get; internal set; }
        public bool speedTicket { get; internal set; }
    }
}