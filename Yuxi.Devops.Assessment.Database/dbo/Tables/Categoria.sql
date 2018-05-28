CREATE TABLE [dbo].[Categoria] (
    [Codigo] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

