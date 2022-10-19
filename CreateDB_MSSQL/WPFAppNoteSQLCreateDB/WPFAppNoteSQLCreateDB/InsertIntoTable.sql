INSERT INTO [dbo].[NoteTable] 
	([MenuTitle], [NoteTitle], [NoteText],[NoteCreateDateTime] ,[NoteEditDateTime], [ColorText]) 
VALUES 
(NULL, NULL,NULL,NULL,NULL,NULL),
('ТестМеню2', 'ЗаголовокМеню2','Какой-то небольшой текст2',GETDATE(), GETDATE(), '#AABBCC' );

SELECT * FROM [dbo].[NoteTable];