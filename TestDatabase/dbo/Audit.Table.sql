CREATE TABLE [dbo].[Audit](
	[Id] INT IDENTITY(1,1) Primary key NOT NULL,
	[TableName] VARCHAR(50) NOT NULL,
	[TimeStamp] DateTime NOT NULL,
	[User]	VARCHAR(50) NOT NULL
)