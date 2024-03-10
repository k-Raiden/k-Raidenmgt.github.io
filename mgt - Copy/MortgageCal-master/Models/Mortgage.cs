namespace MortgageCal.Models
{
    public class Mortgage
    {
        public double Principal { get; set; }
        public double TotalLoanAmount { get; set; }

         public double DownPayment { get; set; }
        //Principal= loan amount.//
        public double  PropertyTax { get; set; }
        
        public double Insurance { get; set; } 
        public double Apr { get; set; }

        //Apr is annual//

        public double LoanTerm { get; set; }// length of the loan.

        public double TotalLoanInterest{ get; set;}

        public double MonthlyPayment { get; set; }










    }
}
