CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT IDENTITY NOT NULL, 
    [idClient] INT NOT NULL, 
    [idCanceler] INT NULL, 
    [dateDebut] DATE NOT NULL, 
    [dateFin] DATE NOT NULL, 
    [nbPersonne] TINYINT NOT NULL DEFAULT 1, 
    [nbEnfant] TINYINT NOT NULL DEFAULT 0, 
    [dateAnnulation] DATETIME NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]), 
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]),
    CONSTRAINT [FK_Reservation_Canceler] FOREIGN KEY ([idCanceler]) REFERENCES [Client]([idClient]),
    CONSTRAINT [CK_Reservation_nbPersonne] CHECK (nbPersonne >= 1)
)
