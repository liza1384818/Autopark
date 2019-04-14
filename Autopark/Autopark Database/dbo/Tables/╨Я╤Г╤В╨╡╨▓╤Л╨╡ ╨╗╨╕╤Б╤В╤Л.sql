CREATE TABLE [dbo].[Путевые листы] (
    [№ путевого листа]      INT        NOT NULL,
    [Дата отправления]      DATE       NULL,
    [Время выезда]          TIME (2)   NULL,
    [Время возврата]        TIME (2)   NULL,
    [Топливо при выезде]    INT        NOT NULL,
    [Топливо при возврате]  INT        NOT NULL,
    [Масса груза]           INT        NULL,
    [Водитель]              INT        NULL,
    [Маршрут]               INT        NULL,
    [Транспортное средство] NCHAR (10) NULL,
    CONSTRAINT [PK_Путевые листы] PRIMARY KEY CLUSTERED ([№ путевого листа] ASC),
    CONSTRAINT [FK_Путевые листы_Картотека водителей] FOREIGN KEY ([Водитель]) REFERENCES [dbo].[Картотека водителей] ([ID водителя]),
    CONSTRAINT [FK_Путевые листы_Маршруты] FOREIGN KEY ([Маршрут]) REFERENCES [dbo].[Маршруты] ([ID маршрута]),
    CONSTRAINT [FK_Путевые листы_Транспортные средства] FOREIGN KEY ([Транспортное средство]) REFERENCES [dbo].[Транспортные средства] ([Инвентарный номер])
);

