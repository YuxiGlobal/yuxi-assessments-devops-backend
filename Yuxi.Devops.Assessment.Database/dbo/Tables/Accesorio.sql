CREATE TABLE [dbo].[Accesorio] (
    [Codigo] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Accesorio_1] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

