using System;

namespace LendingSystem.Core.Domain
{


   public class Guarrantor
    {
       public int GuarrantorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public Loan Loan { get; set; }
        public Int64 LoanId { get; set; }

    }
}
