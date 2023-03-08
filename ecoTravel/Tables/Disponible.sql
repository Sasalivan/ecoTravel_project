CREATE TABLE [dbo].[Disponible]
(
	[IdDisponible] INT IDENTITY NOT NULL, 
    [idLogement] INT NOT NULL, 
    [dateDebut] DATETIME NOT NULL, 
    [dateFin] DATETIME NOT NULL, 
    CONSTRAINT [PK_Disponible] PRIMARY KEY ([IdDisponible]), 
    CONSTRAINT [FK_Disponible_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]) 
)
