CREATE TABLE [dbo].[AuditParameter]
(
	[Id]	INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ParentID] INT NOT NULL,
	[PreviousID] INT NULL,
	[Key] VARCHAR(50) NOT NULL,
	[Value] VARCHAR(Max) NOT NULL,
	CONSTRAINT [FK_Audit_Id] FOREIGN KEY ([ParentID]) REFERENCES [Audit]([Id]),
	CONSTRAINT [FK_AuditParameters_Id] FOREIGN KEY ([PreviousID]) REFERENCES [AuditParameter]([Id])
)