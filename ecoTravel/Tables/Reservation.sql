CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT IDENTITY NOT NULL, 
    [idClient] INT NOT NULL, 
    [idCanceler] INT NOT NULL, 
    [dateDebut] DATETIME NOT NULL, 
    [dateFin] DATETIME NOT NULL, 
    [nbPersonne] INT NOT NULL, 
    [prixTotal] MONEY NOT NULL, 
    [dateAnnulation] DATETIME NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]), 
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]),
    CONSTRAINT [FK_Reservation_Canceler] FOREIGN KEY ([idCanceler]) REFERENCES [Client]([idClient]) 
)
