CREATE TABLE [dbo].[User]
(
	[userId] INT NOT NULL PRIMARY KEY, 
    [imie] NVARCHAR(50) NULL, 
    [nazwisko] NVARCHAR(50) NULL, 
    [login] NVARCHAR(50) NOT NULL, 
    [haslo] NVARCHAR(50) NOT NULL, 
    [uprawnienia] BIT NOT NULL

)
