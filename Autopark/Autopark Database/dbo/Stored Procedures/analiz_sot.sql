
CREATE PROCEDURE analiz_sot
@put int,
@d date
AS

SELECT distinct [Фамилия],[Имя],[Отчество],[Время выезда],[№ путевого листа]
FROM dbo.[Картотека водителей] JOIN ([dbo].[Путевые листы] join [dbo].[Маршруты] ON Маршрут=[ID маршрута])
 ON Водитель=[ID водителя] 
WHERE  Маршрут=@put AND  [Дата отправления]= @d
			
