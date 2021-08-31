CREATE TABLE [dbo].[Movie]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Title] VARCHAR(100) NOT NULL,
	[Synopsis] VARCHAR(250),
	[ReleaseYear] INT,
	[RealisatorID] INT,
	[ScenaristID] INT
	CONSTRAINT FK_Real FOREIGN KEY (RealisatorID) REFERENCES Person(Id), 
	CONSTRAINT FK_Scen FOREIGN KEY (ScenaristID) REFERENCES Person(Id) 
)
