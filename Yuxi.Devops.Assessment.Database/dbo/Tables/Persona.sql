CREATE TABLE [dbo].[Persona] (
    [Codigo]                   BIGINT         IDENTITY (1, 1) NOT NULL,
    [CodigoTipoIdentificacion] INT            NOT NULL,
    [Identificacion]           NVARCHAR (50)  NOT NULL,
    [Nombres]                  NVARCHAR (50)  NOT NULL,
    [Apellidos]                NVARCHAR (50)  NULL,
    [CorreoElectronico]        NVARCHAR (100) NULL,
    [Celular]                  NUMERIC (10)   NULL,
    CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_Usuario_TipoIdentificacion] FOREIGN KEY ([CodigoTipoIdentificacion]) REFERENCES [dbo].[TipoIdentificacion] ([Codigo]),
    CONSTRAINT [IX_Usuario] UNIQUE NONCLUSTERED ([CodigoTipoIdentificacion] ASC, [Identificacion] ASC)
);

