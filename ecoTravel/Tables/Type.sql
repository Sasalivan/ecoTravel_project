CREATE TABLE [dbo].[Type]
(
	[IdType] INT IDENTITY NOT NULL, 
    [idLogement] INT NOT NULL, 
    [typeLogement] NVARCHAR(50) NOT NULL UNIQUE, 
    CONSTRAINT [PK_Type] PRIMARY KEY ([IdType]), 
    CONSTRAINT [FK_Type_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]) 
)
