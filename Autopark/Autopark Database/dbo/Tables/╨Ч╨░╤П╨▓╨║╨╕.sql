CREATE TABLE [dbo].[Заявки] (
    [№ заявки]          NCHAR (10) NOT NULL,
    [Количество]        INT        NOT NULL,
    [Единица измерения] NCHAR (5)  NOT NULL,
    [ГСМ]               INT        NULL,
    [Поставщик]         NCHAR (10) NULL,
    [Дата]              DATE       NULL,
    CONSTRAINT [PK_Заявка] PRIMARY KEY CLUSTERED ([№ заявки] ASC),
    CONSTRAINT [FK_Заявка_ГСМ] FOREIGN KEY ([ГСМ]) REFERENCES [dbo].[ГСМ] ([ID ГСМ]),
    CONSTRAINT [FK_Заявка_Поставщики] FOREIGN KEY ([Поставщик]) REFERENCES [dbo].[Поставщики] ([Код поставщика])
);

