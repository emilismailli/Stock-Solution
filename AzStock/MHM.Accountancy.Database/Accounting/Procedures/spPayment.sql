CREATE PROC [Accounting].[spPayment]
@userId int
AS
BEGIN
SELECT * FROM Accounting.VwPayment p
END
