alter PROCEDURE [dbo].[BorrowerListGet]
(
  @Keyword nvarchar(100)
)
AS
BEGIN

		IF @Keyword='' BEGIN

						   SELECT  a.BorrowerId,a.FirstName +' '+ a.LastName as FirstName,a.LastName,a.Address,a.BirthDate,a.ContactInfo,a.Designation,a.Gender,a.MonthlyIncome,a.Photo,a.Status,a.OfficeId,
								  isnull((Select sum(Amount) From LoanCharges g INNER JOIN Loans b On g.LoanId=b.LoanId Where b.BorrowerId=a.BorrowerId ),0)
								   + isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where BorrowerId=a.BorrowerId),0)
									-isnull((Select sum(AmountPaid) From LoanPayments h INNER JOIN Loans b On h.LoanId=b.LoanId Where b.BorrowerId=a.BorrowerId),0)
									as Balance
							FROM  Borrowers a WHERE a.Status=1 order by a.Firstname ASC

		END ELSE BEGIN

						   SELECT  a.BorrowerId,a.FirstName +' '+ a.LastName as FirstName,a.LastName,a.Address,a.BirthDate,a.ContactInfo,a.Designation,a.Gender,a.MonthlyIncome,a.Photo,a.Status,a.OfficeId,
								  isnull((Select sum(Amount) From LoanCharges g INNER JOIN Loans b On g.LoanId=b.LoanId Where b.BorrowerId=a.BorrowerId ),0)
								   + isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where BorrowerId=a.BorrowerId),0)
									-isnull((Select sum(AmountPaid) From LoanPayments h INNER JOIN Loans b On h.LoanId=b.LoanId Where b.BorrowerId=a.BorrowerId),0)
									as Balance
							FROM  Borrowers a WHERE a.Status=1 and a.FirstName+' '+ a.LastName like '%'+@keyword+'%' order by a.Firstname ASC

		END


END
