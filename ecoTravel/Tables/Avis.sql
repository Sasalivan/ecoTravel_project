CREATE TABLE [dbo].[Avis]
(
	[IdAvis] INT IDENTITY NOT NULL, 
    [idReservation] INT NOT NULL, 
    [avisEcrit] NVARCHAR(MAX) NOT NULL, 
    [note] TINYINT NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([IdAvis]), 
    CONSTRAINT [FK_Avis_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation]),
    CONSTRAINT [CK_Avis_note] CHECK([note] BETWEEN 0 AND 5)
)
