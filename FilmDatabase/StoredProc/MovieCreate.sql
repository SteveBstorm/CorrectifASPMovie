CREATE PROCEDURE [dbo].[MovieCreate]
	@Title VARCHAR(100),
	@Synopsis VARCHAR(250),
	@ReleaseYear INT,
	@RealisatorId INT,
	@ScenaristId INT
AS
BEGIN
	INSERT INTO Movie (Title,Synopsis, ReleaseYear, RealisatorID, ScenaristID)
	VALUES(@Title, @Synopsis, @ReleaseYear, @RealisatorId, @ScenaristId)
END	
