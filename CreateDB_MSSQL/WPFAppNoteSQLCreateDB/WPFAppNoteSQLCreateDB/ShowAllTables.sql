USE NoteDB
go

SELECT name AS [Название таблицы],
           create_date AS [Дата создания],
           modify_date AS [Дата редактирования]
   FROM sys.tables