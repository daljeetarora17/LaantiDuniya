CREATE TABLE [dbo].[tblCategory] (
    [Id]   INT           NOT NULL,
    [Name] VARCHAR (200) NOT NULL,
    [Tags] VARCHAR (500) NULL,
    CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

