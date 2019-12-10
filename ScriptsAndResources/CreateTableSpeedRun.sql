
USE [SpeedRunDatabase];

CREATE TABLE SpeedRun 
(Id int NOT NULL PRIMARY KEY IDENTITY,
RecordDate DateTime NOT NULL,
[Time] bigint NOT NULL,
PlayerId int NOT NULL FOREIGN KEY REFERENCES Player(Id),
GameId int NOT NULL FOREIGN KEY REFERENCES Game(Id));