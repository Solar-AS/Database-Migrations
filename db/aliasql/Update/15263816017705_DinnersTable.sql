CREATE TABLE [dbo].[Dinners]
(
	[Id] INT NOT NULL IDENTITY(1, 1), 
    [Title] NVARCHAR(50) NOT NULL, 
    [EventDate] DATETIMEOFFSET NOT NULL, 
    [Description] NVARCHAR(256) NOT NULL, 
    [HostedBy] NVARCHAR(20) NULL, 
    [ContactPhone] NVARCHAR(20) NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(256) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
