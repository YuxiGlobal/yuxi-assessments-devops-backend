CREATE TABLE [dbo].[EmpresaTransportadora] (
    [Codigo] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (300) NOT NULL,
    CONSTRAINT [PK_EmpresaTransportadora] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

