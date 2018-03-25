CREATE TABLE [dbo].[Individual]
(
	[CustomerId] INT NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(50),
	[LastName] VARCHAR(50), 
    CONSTRAINT [FK_Individual_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id])
)
