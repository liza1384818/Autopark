CREATE TABLE [dbo].[Приход ГСМ] (
    [№ поставки]        INT        NOT NULL,
    [Дата поставки]     DATE       NOT NULL,
    [Количество]        INT        NOT NULL,
    [Единица измерения] NCHAR (5)  NOT NULL,
    [ГСМ]               INT        NULL,
    [Заявка]            NCHAR (10) NULL,
    CONSTRAINT [PK_Приход ГСМ] PRIMARY KEY CLUSTERED ([№ поставки] ASC),
    CONSTRAINT [FK_Приход ГСМ_ГСМ] FOREIGN KEY ([ГСМ]) REFERENCES [dbo].[ГСМ] ([ID ГСМ]),
    CONSTRAINT [FK_Приход ГСМ_Заявка] FOREIGN KEY ([Заявка]) REFERENCES [dbo].[Заявки] ([№ заявки])
);

