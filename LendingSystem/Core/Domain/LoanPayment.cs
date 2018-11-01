using System;


namespace LendingSystem.Core.Domain
{
    public class LoanPayment
    {
        public Int64 LoanPaymentId { get; set; }
        public DateTime DatePost { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentType PaymentType { get; set; }
        public Loan Loan { get; set; }
        public Int64 LoanId { get; set; }
        public string Remark { get; set; }
        public string Reference { get; set; }
    }
       public enum PaymentType
        {
            Principal=1,
            Interest=2
        }


}
