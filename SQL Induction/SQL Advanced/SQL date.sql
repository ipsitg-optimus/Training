--displays dates in required format
DECLARE @Test AS varchar(30)
SET @Test = DATENAME(W,GETDATE())
SET @Test=LEFT(@Test,3)+' ';
SET @Test = @Test+CONVERT(VARCHAR(19),GETDATE(),100)
PRINT @Test


SET @Test=DATEADD(DAY,2,GETDATE())
SET @Test = DATENAME(W,DATEADD(DAY,2,GETDATE()))
SET @Test=LEFT(@Test,3)+' ';
SET @Test = @Test+CONVERT(VARCHAR(19),DATEADD(DAY,2,GETDATE()),100)
PRINT @Test