CREATE TABLE [dbo].[Client]
(
	[IdClient] INT IDENTITY NOT NULL , 
    [nom] NVARCHAR(50) NOT NULL, 
    [prenom] NVARCHAR(50) NOT NULL, 
    [mail] NVARCHAR(MAX) NOT NULL, 
    [pays] NVARCHAR(50) NOT NULL, 
    [telephone] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient]),
    CONSTRAINT [CK_Client_nom] CHECK (LEN([nom]) >= 2),
    CONSTRAINT [CK_Client_prenom] CHECK (LEN([prenom]) >= 2)
)
