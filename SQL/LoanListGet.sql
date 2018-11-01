alter PROCEDURE [dbo].[LoanListGet]
(	 
         @BorrowerId BigInt
  )
AS
BEGIN

		SELECT a.LoanId,a.LoanAmount, a.DateStart,a.TermsOfPayment,a.InterestRate,a.CalendarRate,
				a.Restructure,a.Reference,a.Remark, a.BorrowerId,
				isnull((Select sum(Amount) From LoanCharges c INNER JOIN Loans b On c.LoanId=b.LoanId Where c.LoanId =a.LoanId ),0)
				+ isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=a.LoanId),0) 
				- isnull((Select sum(AmountPaid) From LoanPayments d INNER JOIN Loans b On d.LoanId=b.LoanId Where d.LoanId =a.LoanId ),0) as Balance
		FROM  Loans a WHERE BorrowerId=@BorrowerId 

 END
