CREATE TABLE [dbo].[TipoCarga] (
    [Codigo] INT            IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_TipoCarga] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

