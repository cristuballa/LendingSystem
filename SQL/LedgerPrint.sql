USE [Lending]
GO
/****** Object:  StoredProcedure [dbo].[LedgerGet]    Script Date: 7/22/2017 5:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


alter PROCEDURE [dbo].[LedgerPrint]
(	 
         @LoanId BigInt
  )
AS
BEGIN

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


SELECt (Select FirstName + ' '+LastName  From Borrowers x INNER JOIN Loans y On x.BorrowerId=y.BorrowerId  Where y.LoanId =@LoanId) as Name,
  (Select LoanAmount from Loans WHere LoanId=@LoanId) as LoanAmount, (Select TermsOfPayment  from Loans WHere LoanId=@LoanId) as TermsOfPayment,(Select InterestRate   from Loans WHere LoanId=@LoanId) as InterestRate,
  Convert(int,b.rowid) as rowid, Id,Convert(Int,b.rId) as rId,Convert(int,b.rowid) as rowid,Convert(BigInt,b.Id) as Id, b.DatePost,
  Case b.TransType 
  WHEN 0 THEN 'Loan'
  WHEN 1 THEN 'Payment'
  WHEN 2 THEN 'Charges' END as Trans,
 -- b.TransType  as Trans,
  b.Reference,Convert(float,b.Debit) as Debit,Convert(float,b.Credit) as Credit,b.Remark, 
  Convert(float,(SELECT SUM(Debit) FROM  Ledgers WHERE Id<=b.Id )- (SELECT SUM(Credit) FROM  Ledgers WHERE Id<=b.Id )) as Balance,b.Seq
 From Ledgers b order by  b.DatePost ASC


END
