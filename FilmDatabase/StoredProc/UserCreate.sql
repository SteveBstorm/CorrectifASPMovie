CREATE PROCEDURE [dbo].[UserCreate]
	@Email VARCHAR(100),
	@Password VARCHAR(50),
	@LastName VARCHAR(50),
	@FirstName VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	--Creation du salt
	DECLARE @salt VARCHAR(100)
	SET @salt = NEWID()

	DECLARE @secret VARCHAR(100)
	SET @secret = dbo.GetSecretKey()

	DECLARE @hash_password VARBINARY(64)
	SET @hash_password = HASHBYTES('SHA2_512', CONCAT(@salt, @Password, @secret, @salt))

	INSERT INTO [Users] (Email, [Password], Salt, LastName, FirstName) 
	VALUES (@Email, @hash_password, @salt, @LastName, @FirstName)
END

