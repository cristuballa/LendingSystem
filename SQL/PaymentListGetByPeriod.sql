alter PROCEDURE PaymentListGetByPeriod
(	 
         @DateFrom datetime,
		 @DateTo datetime
)
AS
BEGIN

				   SELECT a.LoanPaymentId,a.DatePost,a.AmountPaid,a.Reference,a.Remark,a.PaymentType,a.LoanId,
				          (Select c.FirstName+ ' '+ c.LastName From Borrowers c INNER JOIN Loans b On c.BorrowerId=b.BorrowerId WHERE b.LoanId =a.LoanId) as Borrower
				   FROM  LoanPayments a WHERE a.DatePost BETWEEN  @DateFrom and @DateTo Order By a.DatePost

END

