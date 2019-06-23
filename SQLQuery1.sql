CREATE TABLE [dbo].[masterList] (
    [Id]         VARCHAR (50)  NOT NULL,
    [Name]       VARCHAR (255) NOT NULL,
    [Contact_No] VARCHAR (255) NULL,
    [Address]    VARCHAR (255) NULL,
    [Gender]     VARCHAR (50)  NOT NULL,
    [Section] VARCHAR(10) NULL, 
    [Image]      IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);