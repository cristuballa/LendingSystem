CREATE PROCEDURE [dbo].[PaymentListGet]
(	 
         @LoanId BigInt
  )
AS
BEGIN
				   SELECT a.LoanPaymentId,a.DatePost,a.AmountPaid,a.Reference,a.Remark,a.PaymentType,a.LoanId 
					FROM  LoanPayments a WHERE LoanId=@LoanId 

END
