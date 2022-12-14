CREATE TABLE [dbo].[Companies]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [CompanyName] NCHAR(10) NOT NULL, 
    [EmployeeID] INT NULL
)
