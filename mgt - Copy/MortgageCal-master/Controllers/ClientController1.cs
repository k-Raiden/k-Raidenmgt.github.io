using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

using MortgageCal.Models;

namespace MortgageCal.Controllers
{
    public class ClientController1 : Controller
    {
        public IActionResult Index()
        {
            Mortgage Model = new Mortgage();
            
            return View(Model);

        }

        [HttpPost]
        public IActionResult CalculateMortgage(Mortgage C )
        {
            C.MonthlyPayment = getMonthlyPayment(C.TotalLoanAmount,C.DownPayment,C.Apr,C.LoanTerm,C.PropertyTax,C.Insurance);
            
           

            return View("Index",C);

        }

        private double getMonthlyPayment(double totalLoanAmount, double downPayment,double apr,double loanTerm,double propertyTax,double insurance)
        {
            //double apr = 0.056;
           // int loanTrm = 360;

            double mortgPayment1;
            double mortgPayment2;
            


            mortgPayment1 = (totalLoanAmount - downPayment) * (Math.Pow((1 + apr / 12), loanTerm) * apr) / (12 * Math.Pow((1 + apr / 12), loanTerm - 1));

            mortgPayment2 = (propertyTax + insurance) / 12 + mortgPayment1;

            double roundMortgagePymnt = Math.Round(mortgPayment2, 2);

            return roundMortgagePymnt;

        }
    }
}
