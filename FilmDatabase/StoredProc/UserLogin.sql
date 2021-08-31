CREATE PROCEDURE [dbo].[UserLogin]
	@Email VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
	DECLARE @salt VARCHAR(100)
	SET @salt = (SELECT salt FROM Users WHERE Email = @Email)

	DECLARE @secret VARCHAR(100)
	SET @secret = dbo.GetSecretKey()

	DECLARE @hash_password VARBINARY(64)
	SET @hash_password = HASHBYTES('SHA2_512', CONCAT(@salt, @Password, @secret, @salt))

	DECLARE @id INT
	SET @id = (SELECT Id FROM Users WHERE Email LIKE @Email AND Password = @hash_password)

	SELECT * FROM V_Users WHERE Id = @id
END
	