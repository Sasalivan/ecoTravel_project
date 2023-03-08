CREATE TABLE [dbo].[Proprio]
(
	[IdClient] INT NOT NULL, 
    CONSTRAINT [PK_Proprio] PRIMARY KEY ([IdClient]), 
    CONSTRAINT [FK_Proprio_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient])
)
