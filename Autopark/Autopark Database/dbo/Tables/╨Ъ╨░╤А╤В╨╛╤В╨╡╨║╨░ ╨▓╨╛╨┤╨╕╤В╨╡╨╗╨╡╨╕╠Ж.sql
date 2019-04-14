CREATE TABLE [dbo].[Картотека водителей] (
    [ID водителя]         INT          NOT NULL IDENTITY,
    [Фамилия]             NCHAR (15)   NOT NULL,
    [Имя]                 NCHAR (10)   NOT NULL,
    [Отчество]            NCHAR (15)   NOT NULL,
    [Дата рождения]       DATE         NOT NULL,
    [Номер телефона]      VARCHAR (20) NULL,
    [Дата получения прав] DATE         NULL,
    CONSTRAINT [PK_Картотека водителей] PRIMARY KEY CLUSTERED ([ID водителя] ASC)
);

