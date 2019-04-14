CREATE TABLE [dbo].[Категории вождения] (
    [Название категории] NCHAR (3)  NOT NULL,
    [Описание]           NCHAR (70) NULL,
    CONSTRAINT [PK_Категории вождения] PRIMARY KEY CLUSTERED ([Название категории] ASC)
);

