
alter FUNCTION [dbo].[AgingAsOf](@DateStarted Date, @Amortization money,@Payment Money,@Term Int,@Type int,@DateAsOf date) RETURNS Money
AS
BEGIN

     Declare @SCHEDULE TABLE( Period INT ,
							 PayDate DATETIME,
							 Amortization MONEY ,
							 Payment MONEY ,
							 Receivable MONEY ,
							 TodayDate DATETIME, 
							 TodayDatePayDateDiff Int ) 

    --Declare @DateStarted Datetime,@Payment money,@Term int,, @Amortization money
    
	Declare @x int,@AmtPaid money
	Declare @Receivable money
	Declare @Paydate DATETIME
	
	--Set @DateStarted='1/18/2011'
	--Set @Payment=4800
	--set @term=24
	--set @Amortization=500
	
	
	set @x=1
	Set @Paydate=@DateStarted
	
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
			@SCHEDULE(Period, 
			PayDate, 
			Amortization, 
			Payment,
			Receivable, 
			TodayDate, 
			TodayDatePayDateDiff) VALUES (
			
			@x, 
			@Paydate, 
			@Amortization, 
			@AmtPaid, 
			@Receivable, 
			GetDate(),
			DateDiff(day,@Paydate,@DateAsOf))
			
		 Set @x=@x+1
		 set @Paydate=DATEADD(month,1,@Paydate)
	End
	
	RETURN CASE @Type
	 WHEN 1 THEN ISNULL((Select SUM(Receivable) From @SCHEDULE WHERE TodayDatePayDateDiff >= 0 and TodayDatePayDateDiff<31),0)
	 WHEN 2 THEN ISNULL((Select SUM(Receivable) From @SCHEDULE WHERE TodayDatePayDateDiff > 30 and TodayDatePayDateDiff<61),0)
	 WHEN 3 THEN ISNULL((Select SUM(Receivable) From @SCHEDULE WHERE TodayDatePayDateDiff > 60 and TodayDatePayDateDiff<91),0)
	 WHEN 4 THEN ISNULL((Select SUM(Receivable) From @SCHEDULE WHERE TodayDatePayDateDiff > 90 ),0)
	 WHEN 5 THEN ISNULL((Select SUM(Receivable) From @SCHEDULE WHERE TodayDatePayDateDiff >= 0),0)
	 WHEN 6 THEN ISNULL((Select Max(TodayDatePayDateDiff) From @SCHEDULE WHERE TodayDatePayDateDiff>0 and Receivable>0),0)
	 ELSE 0
	END 

END