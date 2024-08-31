CREATE TABLE [dbo].[Acesso] (
    [intCodigo]    INT            IDENTITY (1, 1) NOT NULL,
    [intOperador]  INT            NOT NULL,
    [intAplicacao] INT            NOT NULL,
    [strToken]     NVARCHAR (250) NULL,
    [bitAtivo]     BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([intCodigo] ASC),
    FOREIGN KEY ([intAplicacao]) REFERENCES [dbo].[Aplicacao] ([intCodigo]),
    FOREIGN KEY ([intOperador]) REFERENCES [dbo].[Operadores] ([intCodigo])
);

