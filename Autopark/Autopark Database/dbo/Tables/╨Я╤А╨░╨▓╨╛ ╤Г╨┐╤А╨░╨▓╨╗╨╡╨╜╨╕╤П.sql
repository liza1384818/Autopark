CREATE TABLE [dbo].[Право управления] (
    [Водитель]  INT       NOT NULL,
    [Категория] NCHAR (3) NOT NULL,
    CONSTRAINT [FK_Право управления_Картотека водителей] FOREIGN KEY ([Водитель]) REFERENCES [dbo].[Картотека водителей] ([ID водителя]),
    CONSTRAINT [FK_Право управления_Категории вождения] FOREIGN KEY ([Категория]) REFERENCES [dbo].[Категории вождения] ([Название категории])
);

