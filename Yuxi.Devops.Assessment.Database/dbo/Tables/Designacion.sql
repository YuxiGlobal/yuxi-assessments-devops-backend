CREATE TABLE [dbo].[Designacion] (
    [Codigo]                 INT            IDENTITY (1, 1) NOT NULL,
    [Configuracion]          VARCHAR (5)    NOT NULL,
    [CodigoSubClasificacion] INT            NOT NULL,
    [Descripcion]            NVARCHAR (500) NOT NULL,
    [EjesAutomotor]          INT            NOT NULL,
    [EjesNoAutomotor]        INT            NULL,
    [AnchoMaximo]            DECIMAL (5, 2) NOT NULL,
    [AlturaMaxima]           DECIMAL (5, 2) NOT NULL,
    [LongitudMaxima]         DECIMAL (5, 2) NOT NULL,
    [PesoBrutoVehicular]     NUMERIC (8)    NOT NULL,
    [Tolerancia]             NUMERIC (4)    NOT NULL,
    CONSTRAINT [PK_Designacion] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_Designacion_SubClasificacion] FOREIGN KEY ([CodigoSubClasificacion]) REFERENCES [dbo].[SubClasificacion] ([Codigo]),
    CONSTRAINT [IX_Designacion] UNIQUE NONCLUSTERED ([Configuracion] ASC)
);

