CREATE TABLE [dbo].[tblPost] (
    [Id]           INT            NOT NULL,
    [Title]        VARCHAR (500)  NOT NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [Tags]         VARCHAR (500)  NULL,
    [CreatedDate]  DATETIME       NOT NULL,
    [ModifiedDate] DATETIME       NOT NULL,
    [IsDeleted]    BIT            NOT NULL,
    [IsActive]     BIT            NOT NULL,
    CONSTRAINT [PK_tblPost] PRIMARY KEY CLUSTERED ([Id] ASC)
);

