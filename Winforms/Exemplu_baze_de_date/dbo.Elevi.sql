CREATE TABLE [dbo].[Elevi]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NULL, 
    [Prenume] NVARCHAR(50) NULL, 
    [CNP] NVARCHAR(13) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Adresa] NVARCHAR(50) NULL
)
