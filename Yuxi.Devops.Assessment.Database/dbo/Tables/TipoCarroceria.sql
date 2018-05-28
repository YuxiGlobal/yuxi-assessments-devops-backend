CREATE TABLE [dbo].[TipoCarroceria] (
    [Codigo] INT            IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_TipoCarroceria] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

