CREATE FUNCTION [dbo].[GetSecretKey]
()
RETURNS VARCHAR
AS
BEGIN
	DECLARE @secret VARCHAR(100);
	SET @secret = 'Les framboisiers SONT sur le TABOURET de MON grand PERE'
	RETURN @secret
END
