CREATE TABLE [dbo].[AccesorioVehiculo] (
    [Codigo]          BIGINT   IDENTITY (1, 1) NOT NULL,
    [CodigoAccesorio] INT      NOT NULL,
    [CodigoVehiculo]  BIGINT   NOT NULL,
    [Cantidad]        SMALLINT NOT NULL,
    CONSTRAINT [PK_AccesorioVehiculo_1] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_AccesorioVehiculo_Accesorio] FOREIGN KEY ([CodigoAccesorio]) REFERENCES [dbo].[Accesorio] ([Codigo]),
    CONSTRAINT [FK_AccesorioVehiculo_Vehiculo] FOREIGN KEY ([CodigoVehiculo]) REFERENCES [dbo].[Vehiculo] ([Codigo]),
    CONSTRAINT [IX_AccesorioVehiculo] UNIQUE NONCLUSTERED ([CodigoVehiculo] ASC, [CodigoAccesorio] ASC)
);

