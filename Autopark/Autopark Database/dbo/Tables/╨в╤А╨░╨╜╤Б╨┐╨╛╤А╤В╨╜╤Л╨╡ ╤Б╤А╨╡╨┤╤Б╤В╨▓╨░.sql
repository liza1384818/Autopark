CREATE TABLE [dbo].[Транспортные средства] (
    [Инвентарный номер]   NCHAR (10) NOT NULL,
    [Название]            NCHAR (10) NOT NULL,
    [Тип автомобиля]      NCHAR (15) NOT NULL,
    [Год выпуска]         DATE       NOT NULL,
    [Грузоподъемность/т]  INT        NOT NULL,
    [Объем бака]          INT        NOT NULL,
    [Страна-изготовитель] NCHAR (10) NULL,
    [ГСМ]                 INT        NULL,
    [Категория]           NCHAR (3)  NULL,
    CONSTRAINT [PK_Транспортные средства] PRIMARY KEY CLUSTERED ([Инвентарный номер] ASC),
    CONSTRAINT [FK_Транспортные средства_ГСМ] FOREIGN KEY ([ГСМ]) REFERENCES [dbo].[ГСМ] ([ID ГСМ]),
    CONSTRAINT [FK_Транспортные средства_Категории вождения] FOREIGN KEY ([Категория]) REFERENCES [dbo].[Категории вождения] ([Название категории])
);


GO
CREATE NONCLUSTERED INDEX [IX_Транспортные средства]
    ON [dbo].[Транспортные средства]([Инвентарный номер] ASC);

