alter PROCEDURE [dbo].[AgingReceivablesByOffice]

AS 
BEGIN

declare @DateAsOf datetime
set @DateAsOf=GetDate()

 declare @AOR TABLE 
	( 
	    IdPk int IDENTITY(1,1)  NOT NULL PRIMARY KEY,
		LoanId BigInt,
		DueDate datetime,
        BorrowerId numeric,
		LoanAmount money,
		InterestRate money,
		TermsOfPayment int,
		AmountDue money,
		Payment money,
		Balance money,
		DueToDate money,
		Aging1_30Days money,
		Aging31_60Days money,
		Aging61_90Days money,
		Aging91UpDays money,
		AgingNoOfDays money

	) 


    INSERT INTO @AOR (DueDate,LoanId,BorrowerId,LoanAmount,InterestRate,TermsOfPayment,AmountDue,Payment,Balance,
	                  Aging1_30Days ,Aging31_60Days, Aging61_90Days ,Aging91UpDays,AgingNoOfDays, DueToDate )
            
			Select  b.DateStart,b.LoanId,b.BorrowerId,b.LoanAmount,b.InterestRate,b.TermsOfPayment,
		
						  isnull((Select sum(Amount) From LoanCharges Where LoanId =b.LoanId ),0)
						   + isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=b.LoanId),0) as AmountDue,

						   isnull((Select sum(AmountPaid) From LoanPayments   Where LoanId =b.LoanId ),0) as Payment,

						 isnull((Select sum(Amount) From LoanCharges Where LoanId =b.LoanId ),0)
						 + isnull((Select Sum(LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment)) From Loans Where  LoanId=b.LoanId),0) 
						 -isnull((Select sum(AmountPaid) From LoanPayments  Where LoanId =b.LoanId ),0) as Balance,

                ----------------------------------Aging1_30Days--------------------------					 
 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									 isnull((Select sum(AmountPaid) From LoanPayments   Where LoanId =b.LoanId ),0),
									b.TermsOfPayment,1,@DateAsOf) ,0) as Aging1_30Days,


				----------------------------------Aging31_60Days--------------------------			 	
 		  
 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									   isnull((Select sum(AmountPaid) From LoanPayments d  Where d.LoanId =b.LoanId ),0) ,
									b.TermsOfPayment,2,@DateAsOf) ,0) as Aging31_60Days,


				----------------------------------Aging61-90Days--------------------------

 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									 isnull((Select sum(AmountPaid) From LoanPayments d  Where d.LoanId =b.LoanId ),0) ,
									 b.TermsOfPayment,3,@DateAsOf) ,0) as Aging61_90Days,


				----------------------------------Aging90DaysUp--------------------------

 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									isnull((Select sum(AmountPaid) From LoanPayments d  Where d.LoanId =b.LoanId ),0) ,
									b.TermsOfPayment,4,@DateAsOf) ,0) as Aging91UpDays,


				----------------------------------AgingNoOfDays--------------------------
 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									isnull((Select sum(AmountPaid) From LoanPayments d  Where d.LoanId =b.LoanId ),0) ,
									b.TermsOfPayment,6,@DateAsOf) ,0) as  AgingNoOfDays,


				----------------------------------DUE-------------------------------------
 				ISNULL(dbo.AgingAsOf(b.DateStart,
									(isnull((Select (LoanAmount +(LoanAmount*(InterestRate/100)*TermsOfPayment))/TermsOfPayment From Loans Where  LoanId=b.LoanId),0)),
									   isnull((Select sum(AmountPaid) From LoanPayments d  Where d.LoanId =b.LoanId ),0) ,
									b.TermsOfPayment,5,@DateAsOf) ,0)	as DueToDate
	
	     FROM  Loans b  WHERE b.DateStart <=@DateAsOf ORDER BY b.LoanId

		 Select b.FirstName+' '+b.LastName as Name,b.Address,b.ContactInfo, a.Balance,a.Payment,a.AmountDue,a.DueDate,a.TermsOfPayment,(Select Name From Offices WHERE OfficeId =b.OfficeId) as Offices,
		  
		       CONVERT(date, CAST(DATEPART(month,getdate()) AS char(2)) + '-' + CAST(DATEPART(day,getdate()) AS char(2)) +'-'+ CAST(DATEPART(YEAR ,getdate()) AS char(4)),101) as DueDate1

		         ,CASE WHEN isnull(a.Aging1_30Days,0)=0 THEN NULL 
			      ELSE isnull(a.Aging1_30Days,0) END as Aging1_30Days
			      
		         ,CASE WHEN isnull(a.Aging31_60Days,0)=0 THEN NULL 
			      ELSE isnull(a.Aging31_60Days,0) END as Aging31_60Days	

		         ,CASE WHEN isnull(a.Aging61_90Days,0)=0 THEN NULL 
			      ELSE isnull(a.Aging61_90Days,0) END as Aging61_90Days	

		         ,CASE WHEN isnull(a.Aging91UpDays,0)=0 THEN NULL 
			      ELSE isnull(a.Aging91UpDays,0)END as Aging91UpDays	

		         ,CASE WHEN isnull(a.AgingNoOfDays,0)=0 THEN NULL 
			      ELSE isnull(a.AgingNoOfDays,0) END as AgingNoOfDays	
				  
				  ,CASE WHEN isnull(a.DueToDate,0)=0 THEN NULL 
			      ELSE isnull(a.DueToDate,0) END as Due

		From @AOR a  INNER JOIN Borrowers b ON a.BorrowerId  =b.BorrowerId  WHERE b.Status =1 and isnull(a.balance,0)>0  ORDER BY Offices     
		 

END