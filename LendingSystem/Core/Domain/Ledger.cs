using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingSystem.Core.Domain
{
    public class Ledger
    {

        public Int64 Id { get; set; }
        public int rowid { get; set; }
        public DateTime DatePost { get; set; }
        public TransType TransType { get; set; }
        public string Reference { get; set; }
        public string Remark { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }
        public int Seq { get; set; }
        public int rId { get; set; }


    } 

    public enum TransType
    {
        Loan =0,
        Payment=1,
        Charges=2
    }
}
