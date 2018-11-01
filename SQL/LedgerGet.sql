

alter PROCEDURE LedgerGet
(	 
         @LoanId BigInt
  )
AS
BEGIN

--WITH 
--Ledger_CTE (Seq,rId,DatePost,TransType,Debit,Credit,Reference,Remark)
--AS
--( 
--	SELECT 0 as Seq,Id=a.LoanId,DatePost= a.DateStart,0 as TransType,
--			isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=a.LoanId),0)  as Debit, 
--			0 as Credit ,
--			a.Reference,a.Remark
--	FROM  Loans a WHERE LoanId=@LoanId 

--    UNION ALL

--	SELECT 1 as Seq, rId=a.LoanPaymentId,DatePost=a.DatePost,1 as TransType,0 as Debit, a.AmountPaid as Credit,a.Reference,a.Remark
--	FROM  LoanPayments a WHERE LoanId=@LoanId 

--	UNION ALL

--	SELECT 2 as Seq, rId=a.LoanChargeId,DatePost=a.DatePost,2 as TransType, a.Amount as Debit,0 as Credit,a.Reference,a.Remark
--	FROM  LoanCharges a WHERE a.LoanId=@LoanId 
-- ),
-- LedgerCTE2 (rowid, Seq,rId,TransType,DatePost,Debit,Credit,Reference,Remark )
-- AS
-- (
-- SELECt  row_number() over (order by DatePost,Seq) as rowid, Seq,rId,TransType,DatePost,Debit,Credit,Reference,Remark  From Ledger_CTE
--) 

-- SELECt  Convert(Int,b.rId) as rId,Convert(int,b.rowid) as rowid,Convert(BigInt,0) as Id, b.DatePost,TransType,b.Reference,Convert(float,b.Debit) as Debit,Convert(float,b.Credit) as Credit,b.Remark, 
--  Convert(float,(SELECT SUM(Debit) FROM  LedgerCTE2 WHERE rowid<=b.rowid )- (SELECT SUM(Credit) FROM  LedgerCTE2 WHERE rowid<=b.rowid  )) as Balance,b.Seq
-- From LedgerCTE2 b


truncate table Ledgers

 Insert INTO Ledgers (Seq,rId,DatePost,TransType,Debit,Credit,Reference,Remark,Balance)  

  SELECT 0 as Seq,rId=a.LoanId,DatePost= a.DateStart,0 as TransType,
			isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=a.LoanId),0)  as Debit, 
			0 as Credit ,
			a.Reference,a.Remark,0 as Balace
	FROM  Loans a WHERE LoanId=@LoanId
    UNION ALL

	SELECT 1 as Seq, rId=a.LoanPaymentId,DatePost=a.DatePost,1 as TransType,0 as Debit, a.AmountPaid as Credit,a.Reference,a.Remark,0 as Balace
	FROM  LoanPayments a WHERE LoanId=@LoanId

	UNION ALL

	SELECT 2 as Seq, rId=a.LoanChargeId,DatePost=a.DatePost,2 as TransType, a.Amount as Debit,0 as Credit,a.Reference,a.Remark,0 as Balace
	FROM  LoanCharges a WHERE a.LoanId=@LoanId  Order by DatePost ASC



SELECt Convert(int,b.rowid) as rowid, Id,Convert(Int,b.rId) as rId,Convert(int,b.rowid) as rowid,Convert(BigInt,b.Id) as Id, b.DatePost,TransType,b.Reference,Convert(float,b.Debit) as Debit,Convert(float,b.Credit) as Credit,b.Remark, 
  Convert(float,(SELECT SUM(Debit) FROM  Ledgers WHERE Id<=b.Id )- (SELECT SUM(Credit) FROM  Ledgers WHERE Id<=b.Id )) as Balance,b.Seq
 From Ledgers b order by  b.DatePost ASC

END
