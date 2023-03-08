CREATE TABLE [dbo].[Photo]
(
	[IdPhoto] INT NOT NULL, 
    [idLogement] INT NOT NULL, 
    [url] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([IdPhoto]), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]) 
)
