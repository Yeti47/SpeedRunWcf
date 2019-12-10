
USE [SpeedRunDatabase];

CREATE TABLE [Player] 
(Id int NOT NULL PRIMARY KEY IDENTITY,
GamerTag nvarchar(80) NOT NULL)


INSERT INTO [Player] 
(GamerTag) 
VALUES
('LuckyGoodrich90'),
('InfernoBoi47'),
('TheUltimatePlayer');
