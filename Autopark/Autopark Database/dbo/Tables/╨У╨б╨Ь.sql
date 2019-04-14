CREATE TABLE [dbo].[ГСМ] (
    [ID ГСМ]            INT        NOT NULL,
    [Наименование]      NCHAR (10) NOT NULL,
    [Единица измерения] NCHAR (5)  NOT NULL,
    CONSTRAINT [PK_ГСМ] PRIMARY KEY CLUSTERED ([ID ГСМ] ASC)
);

