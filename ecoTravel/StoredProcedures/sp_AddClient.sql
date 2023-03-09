CREATE PROCEDURE [dbo].[AddClient]
	@nom NVARCHAR(50), 
    @prenom NVARCHAR(50), 
    @mail NVARCHAR(250), 
    @pays NVARCHAR(50), 
    @telephone NVARCHAR(50), 
    @password NVARCHAR(32)
AS
	INSERT INTO [Client] ([nom],[prenom],[mail],[pays],[telephone],[password])
	OUTPUT [inserted].[idClient]
	VALUES (@nom, @prenom,@mail, @pays, @telephone, HASHBYTES('SHA2_512',@password))