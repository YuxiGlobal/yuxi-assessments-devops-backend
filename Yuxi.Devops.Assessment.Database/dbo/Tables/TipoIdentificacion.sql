CREATE TABLE [dbo].[TipoIdentificacion] (
    [Codigo]   INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]   NVARCHAR (50) NOT NULL,
    [Acronimo] NVARCHAR (5)  NOT NULL,
    CONSTRAINT [PK_TipoIdentificacion] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

