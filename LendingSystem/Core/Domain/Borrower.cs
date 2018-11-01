
using System;
using System.Collections.Generic;



namespace LendingSystem.Core.Domain
{

   public class Borrower
    {
        public Int64  BorrowerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactInfo { get; set; }
        public string Designation { get; set; }
        public decimal MonthlyIncome  { get; set; }
        public double Balance { get; set; }
        public Boolean  Status { get; set; }
        public Office Office { get; set; }
        public int OfficeId { get; set; }
        public byte[] Photo { get; set; }
        public IList<Loan> Loans { get; set; }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }



    }
}
