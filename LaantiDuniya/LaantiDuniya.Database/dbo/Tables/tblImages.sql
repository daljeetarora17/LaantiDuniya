CREATE TABLE [dbo].[tblImages]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PostId] INT NOT NULL, 
    [ImagePath] NVARCHAR(MAX) NULL
)
