CREATE TABLE [dbo].[Заправка техники] (
    [№ заправки]         INT       NOT NULL,
    [Дата заправки]      DATE      NOT NULL,
    [Время заправки]     TIME (7)  NULL,
    [Количество топлива] INT       NOT NULL,
    [Единица измерения]  NCHAR (5) NOT NULL,
    [Путевой лист]       INT       NULL,
    [ГСМ]                INT       NULL,
    CONSTRAINT [PK_Заправка техники] PRIMARY KEY CLUSTERED ([№ заправки] ASC),
    CONSTRAINT [FK_Заправка техники_ГСМ] FOREIGN KEY ([ГСМ]) REFERENCES [dbo].[ГСМ] ([ID ГСМ]),
    CONSTRAINT [FK_Заправка техники_Путевые листы] FOREIGN KEY ([Путевой лист]) REFERENCES [dbo].[Путевые листы] ([№ путевого листа])
);

