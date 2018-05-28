CREATE TABLE [dbo].[Conductor] (
    [Codigo]                   BIGINT IDENTITY (1, 1) NOT NULL,
    [CodigoUsuario]            BIGINT NOT NULL,
    [CodigoLicenciaConduccion] INT    NOT NULL,
    CONSTRAINT [PK_Conductor] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_Conductor_LicenciaConduccion] FOREIGN KEY ([CodigoLicenciaConduccion]) REFERENCES [dbo].[LicenciaConduccion] ([Codigo]),
    CONSTRAINT [FK_Conductor_Usuario] FOREIGN KEY ([CodigoUsuario]) REFERENCES [dbo].[Persona] ([Codigo])
);

