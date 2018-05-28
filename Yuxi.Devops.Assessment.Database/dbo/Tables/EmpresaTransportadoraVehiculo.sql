CREATE TABLE [dbo].[EmpresaTransportadoraVehiculo] (
    [Codigo]                      BIGINT IDENTITY (1, 1) NOT NULL,
    [CodigoEmpresaTransportadora] BIGINT NOT NULL,
    [CodigoVehiculo]              BIGINT NOT NULL,
    [CodigoCategoria]             INT    NOT NULL,
    CONSTRAINT [PK_EmpresaTransportadoraVehiculo_1] PRIMARY KEY CLUSTERED ([Codigo] ASC),
    CONSTRAINT [FK_EmpresaTransportadoraVehiculo_Categoria] FOREIGN KEY ([CodigoCategoria]) REFERENCES [dbo].[Categoria] ([Codigo]),
    CONSTRAINT [FK_EmpresaTransportadoraVehiculo_EmpresaTransportadora] FOREIGN KEY ([CodigoEmpresaTransportadora]) REFERENCES [dbo].[EmpresaTransportadora] ([Codigo]),
    CONSTRAINT [FK_EmpresaTransportadoraVehiculo_Vehiculo] FOREIGN KEY ([CodigoVehiculo]) REFERENCES [dbo].[Vehiculo] ([Codigo])
);

