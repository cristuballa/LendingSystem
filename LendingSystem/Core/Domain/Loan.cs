using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;


namespace LendingSystem.Core.Domain
{

    public class Loan
    {

        public Int64 LoanId { get; set; }
        public float LoanAmount { get; set; }
        public DateTime DateStart { get; set; }
        public float TermsOfPayment { get; set; }
        public float InterestRate { get; set; }
        public CalendarRate CalendarRate { get; set; }
        public int Restructure { get; set; }
        public string Remark { get; set; }
        public string Reference { get; set; }
        public IList<Guarrantor> Guarrantors { get; set; }
        public IList<LoanPayment> LoanPayments { get; set; }
        public IList<LoanCharge> LoanCharges { get; set; }
        public Borrower Borrower { get; set; }
        public Int64 BorrowerId { get; set; }
        public double Balance { get; set; }

        public float Amortization
        {
            get { return (LoanAmount + (LoanAmount * ((InterestRate / 100) * TermsOfPayment))) / TermsOfPayment; }
        }

        public float TotalDue
        {
            get { return (LoanAmount + (LoanAmount * ((InterestRate / 100) * TermsOfPayment))); }
        }


    }

    public enum CalendarRate
    {
        Daily=0,
        Weekly=1,
        Monthly=2,
        Yearly = 3
        
    }
}
