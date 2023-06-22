﻿CREATE TABLE [dbo].[GamesNew]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NOT NULL, 
    [ReleaseDate] DATE NOT NULL, 
    [Developer] VARCHAR(50) NULL, 
    [Price] DECIMAL(18, 2) NOT NULL
)
