using CarInsurance.Models;
using System.Web.Mvc;


namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private object insuranceQuoteVM;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsuranceQuote(string firstName, string lastName, string emailAddress, int age, string carMake, string carModel, int carYear, bool dui, bool fullCoverage, int speedTickets)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("There was an error. Please be sure to fill in all values.");
            }

            decimal quote = 50;
            decimal duiPercentage = .25m;
            decimal addFullCoverage = .5m;

            if (age < 25)
            {
                quote += 25;
            }

            else if (age < 18)
            {
                quote += 100;
            }

            else if (age > 100)
            {
                quote += 25;
            }


            if (carYear < 2000)
            {
                quote += 25;
            }

            else if (carYear > 2015)
            {
                quote += 25;
            }


            if (carMake == "Porsche")
            {
                quote += 25;
            }

            else if (carMake == "Porsche"  && carModel == "Carerra 911")
            {
                quote += 25;
            }


            if (dui == true)
            {
              quote *= duiPercentage;
            }

            if (speedTickets > 0)
            {
                quote += speedTickets * 10;
            }

            if (fullCoverage == true)
            {
                quote *= addFullCoverage;
            }

            else
            {

                    using (InsuranceEntities2 db = new InsuranceEntities2())
                    {
                        var insuranceQuote = new InsuranceQuote();
                        insuranceQuote.FirstName = firstName;
                        insuranceQuote.LastName = lastName;
                        insuranceQuote.EmailAddress = emailAddress;
                        insuranceQuote.carMake = carMake;
                        insuranceQuote.carYear = carYear;
                        insuranceQuote.Dui = dui;
                        insuranceQuote.fullCoverage = fullCoverage;
                        insuranceQuote.speedTicket = speedTickets;

                        db.Insurees.Add(insuranceQuote);
                        db.SaveChanges();
               }
            }

        }
    }
}
    