CREATE TABLE [dbo].[LicenciaConduccion] (
    [Codigo]      INT            IDENTITY (1, 1) NOT NULL,
    [Categoria]   VARCHAR (3)    NOT NULL,
    [Descripcion] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_LicenciaConduccion] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

