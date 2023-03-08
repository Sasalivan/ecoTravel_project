CREATE TABLE [dbo].[Avis]
(
	[IdAvis] INT IDENTITY NOT NULL, 
    [idReservation] INT NOT NULL, 
    [avisEcrit] NTEXT NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([IdAvis]), 
    CONSTRAINT [FK_Avis_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation]) 
)
