exec scheduleofpayment  1,45920,'7/22/2017','8/22/2017',1891.667,4000,24

exec Aging  '6/21/2017',1891.667,4000,24,0,'8/23/2017'





declare @DateAsOf date
set @DateAsOf='8/22/2017'

select b.DateStart,(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
		isnull((Select sum(AmountPaid) From LoanPayments   Where LoanId =b.LoanId ),0),
						ISNULL(dbo.AgingAsOf(
									b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									 isnull((Select sum(AmountPaid) From LoanPayments   Where LoanId =b.LoanId ),0),
									b.TermsOfPayment,1,@DateAsOf) ,0) as Aging1_30Days

from Loans b