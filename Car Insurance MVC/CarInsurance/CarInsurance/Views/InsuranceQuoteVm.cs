﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Views
{
    public class InsuranceQuoteVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public bool Dui { get; set; }
        public bool FullCoverage { get; set; }
        public int SpeedTicket { get; set; }
    }
}