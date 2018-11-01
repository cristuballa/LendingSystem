CREATE PROCEDURE [dbo].[LedgertGet]
(	 
         @LoanId BigInt
  )
AS
BEGIN


		SELECT	Id=a.LoanId,DatePost= a.DateStart,0 as TransType,
				isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=a.LoanId),0)  as Debit, 
				0 as Credit ,
				a.Reference,a.Remark
		FROM  Loans a WHERE LoanId=@LoanId 

       UNION ALL

		SELECT Id=a.LoanPaymentId,a.DatePost,1 as TransType,0 as Debit, a.AmountPaid as Credit,a.Reference,a.Remark
		FROM  LoanPayments a WHERE LoanId=@LoanId 

		UNION ALL

		 SELECT Id=a.LoanChargeId,a.DatePost,1 as TransType, 0 as Debit,a.Amount as Credit,a.Reference,a.Remark
		FROM  LoanCharge a WHERE LoanId=@LoanId 

END
