INSERT INTO [dbo].[NoteTable] 
	([MenuTitle], [NoteTitle], [NoteText],[NoteCreateDateTime] ,[NoteEditDateTime], [ColorText]) 
VALUES 
(NULL, NULL,NULL,NULL,NULL,NULL),
('��������2', '�������������2','�����-�� ��������� �����2',GETDATE(), GETDATE(), '#AABBCC' );

SELECT * FROM [dbo].[NoteTable];