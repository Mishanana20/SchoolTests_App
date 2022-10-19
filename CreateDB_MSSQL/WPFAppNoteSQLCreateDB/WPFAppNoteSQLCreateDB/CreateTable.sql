USE NoteDB
go

IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = N'NoteTable')
CREATE TABLE [NoteTable]
(
	ID_column INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MenuTitle VARCHAR(30),
	NoteTitle VARCHAR(50),
	NoteText TEXT,
	NoteCreateDateTime DATETIME,
	NoteEditDateTime DATETIME,
	ColorText VARCHAR(8)
)
go

