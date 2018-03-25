CREATE TABLE [Company]
(
	[CustomerId] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50),
	CONSTRAINT [FK_Company_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id])
)
