using System;

namespace LendingSystem.Core.Domain
{
    public class LoanCharge
    {
        public Int64 LoanChargeId { get; set; }
        public float Amount { get; set; }
        public DateTime DatePost { get; set; }
        public string  Remark { get; set; }
        public string Reference { get; set; }
        public Loan Loan { get; set; }
        public Int64 LoanId { get; set; }

    }
}
