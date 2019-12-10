USE [SpeedRunDatabase]

CREATE TABLE [Game]
(Id int NOT NULL PRIMARY KEY,
[Name] nvarchar(100) NOT NULL,
[Publisher] nvarchar(100) NOT NULL,
[ReleaseDate] DateTime NULL);

INSERT INTO [Game] 
(Id, [Name], [Publisher], [ReleaseDate])
VALUES
(100, 'Super Mario World', 'Nintendo', '1990-11-21');

INSERT INTO [Game]
(Id, [Name], [Publisher], [ReleaseDate])
VALUES 
(101, 'Super Metroid', 'Nintendo', '1994-03-19');


INSERT INTO [Game]
(Id, [Name], [Publisher], [ReleaseDate])
VALUES
(102, 'Final Fantasy VII', 'Square Enix', NULL);


