CREATE TABLE [dbo].[Поставщики] (
    [Код поставщика]             NCHAR (10) NOT NULL,
    [Наименование организации]   NCHAR (20) NOT NULL,
    [ОКПО]                       NCHAR (20) NOT NULL,
    [ИНН/КПП]                    NCHAR (20) NOT NULL,
    [Регион]                     NCHAR (40) NOT NULL,
    [Район]                      NCHAR (25) NULL,
    [Улица]                      NCHAR (20) NULL,
    [Номер дома]                 NCHAR (10) NULL,
    [Наименование банка]         NCHAR (15) NOT NULL,
    [№ расчетного счета]         NCHAR (30) NOT NULL,
    [№ корреспондентского счета] NCHAR (20) NOT NULL,
    [БИК банка]                  NCHAR (9)  NOT NULL,
    CONSTRAINT [PK_Поставщики] PRIMARY KEY CLUSTERED ([Код поставщика] ASC)
);

