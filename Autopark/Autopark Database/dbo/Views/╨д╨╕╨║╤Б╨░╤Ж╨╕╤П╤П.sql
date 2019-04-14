CREATE VIEW Фиксацияя (Дата, Потрачено)
    AS SELECT DATENAME(MONTH,[Дата заправки]), Sum([Количество топлива])
    FROM [Заправка техники]
    Group BY DATENAME(MONTH,[Дата заправки]);


