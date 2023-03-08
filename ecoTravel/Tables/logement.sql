CREATE TABLE [dbo].[Logement]
(
	[IdLogement] INT IDENTITY NOT NULL, 
    [prix] MONEY NOT NULL, 
    [nom] NVARCHAR(50) NOT NULL, 
    [adresse] NVARCHAR(MAX) NOT NULL, 
    [coord_geo] [sys].[geography] NOT NULL, 
    [desc_courte] NVARCHAR(100) NOT NULL, 
    [desc_longue] NTEXT NOT NULL, 
    [nb_chambre] INT NOT NULL, 
    [nb_piece] INT NOT NULL, 
    [nb_sdb] INT NOT NULL, 
    [nb_wc] INT NOT NULL, 
    [capacite] INT NOT NULL, 
    [balcon] BIT NOT NULL, 
    [airco] BIT NOT NULL, 
    [wifi] BIT NOT NULL, 
    [minibar] BIT NOT NULL, 
    [animaux] BIT NOT NULL, 
    [piscine] BIT NOT NULL, 
    [voiturier] BIT NOT NULL, 
    [roomService] BIT NOT NULL, 
    CONSTRAINT [PK_logement] PRIMARY KEY ([IdLogement]) 
)
