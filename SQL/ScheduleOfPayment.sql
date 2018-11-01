
alter PROCEDURE ScheduleOfPayment
(
	@LoanId BigInt
)
AS
BEGIN

     Declare @SCHEDULE TABLE(LoanId BigInt,
							 TotalDue money,
							 Period INT ,
							 PayDate DATETIME,
							 Amortization MONEY ,
							 Payment MONEY ,
							 Receivable MONEY ,
							 TodayDate DATETIME, 
							 TodayDatePayDateDiff Int
							  ) 

    --Declare @DateStarted Datetime,@Payment money,@Term int,, @Amortization money
    
	Declare @TotalDue money,@DateStart date,@DateAsOf Date,@Amortization money,	@Payment Money,	@Term Int
	Declare @x int,@AmtPaid money
	Declare @Receivable money,@TotalDue1 money
	Declare @Paydate DATETIME

	
	Set @DateStart=(Select DateStart From Loans WHERE LoanId=@LoanID)
	Set @DateAsOf=(Select DateStart From Loans WHERE LoanId=@LoanID)
	Set @Amortization=Isnull((Select (LoanAmount+((LoanAmount*(InterestRate/100)) *TermsOfPayment))/TermsOfPayment From Loans WHERE LoanId=@LoanID),0)
	Set @TotalDue=Isnull((Select (LoanAmount+((LoanAmount*(InterestRate/100)) *TermsOfPayment)) From Loans WHERE LoanId=@LoanID),0)


	Set @Payment=0
	Set @Term=Isnull((Select TermsOfPayment From Loans WHERE LoanId=@LoanID),1)

	set @x=1
	Set @Paydate=@DateStart
	set @TotalDue1=@TotalDue

	--set @Amortization=@Payment

	While @x<=@Term  Begin
	    
		IF  @Payment>=@Amortization BEGIN
			set @AmtPaid=@Amortization
		END Else BEGIN 
		    IF  @Payment>0 BEGIN
				set @AmtPaid=@Payment
			END ELSE BEGIN set @AmtPaid=0 END
		END
		
		Set @Payment=@Payment-@Amortization	
        set @Receivable=@Amortization-@AmtPaid
        
			INSERT INTO 
			@SCHEDULE(LoanId,TotalDue,Period, 
			PayDate, 
			Amortization, 
			Payment,
			Receivable, 
			TodayDate, 
			TodayDatePayDateDiff) 
			
			VALUES (
			@LoanId,
			@TotalDue1,
			@x, 
			@Paydate, 
			@Amortization, 
			@AmtPaid, 
			@Receivable, 
			@DateAsOf,
			DateDiff(day,@Paydate,@DateAsOf))
			
		 Set @x=@x+1
		 set @Paydate=DATEADD(month,1,@Paydate)
		 set @TotalDue1=@TotalDue1-@Amortization
	End
	
   Select  (select c.FirstName +' '+ c.LastName from Borrowers c INNER JOIN Loans b ON c.BorrowerId =b.BorrowerId WHERE b.LoanId =a.LoanId),
			a.LoanId,b.DateStart,b.InterestRate,b.LoanAmount,
			b.TermsOfPayment, a.TotalDue,a.Period, 
			a.PayDate, 
			a.Amortization, 
			a.Payment,
			a.Receivable, 
			a.TodayDate, 
			a.TodayDatePayDateDiff From @SCHEDULE a INNER JOIN Loans b On a.LoanId =b.LoanId 

END 
