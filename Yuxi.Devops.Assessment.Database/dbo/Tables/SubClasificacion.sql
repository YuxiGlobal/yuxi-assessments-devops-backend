CREATE TABLE [dbo].[SubClasificacion] (
    [Codigo]              INT           IDENTITY (1, 1) NOT NULL,
    [CodigoClasificacion] INT           NOT NULL,
    [Nombre]              NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SubClasificacion] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_SubClasificacion_Clasificacion] FOREIGN KEY ([CodigoClasificacion]) REFERENCES [dbo].[Clasificacion] ([Codigo])
);

