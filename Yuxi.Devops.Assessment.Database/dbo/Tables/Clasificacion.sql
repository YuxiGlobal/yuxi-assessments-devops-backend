CREATE TABLE [dbo].[Clasificacion] (
    [Codigo] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Clasificacion] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

