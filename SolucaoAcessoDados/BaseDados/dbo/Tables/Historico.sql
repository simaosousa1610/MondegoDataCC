CREATE TABLE [dbo].[Historico] (
    [intCodigo]   INT            IDENTITY (1, 1) NOT NULL,
    [intOperador] INT            NOT NULL,
    [enuAcao]     INT            NOT NULL,
    [jsoDados]    NVARCHAR (MAX) NULL,
    [dtmDataAcao] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([intCodigo] ASC),
    FOREIGN KEY ([enuAcao]) REFERENCES [dbo].[Acao] ([intCodigo]),
    FOREIGN KEY ([intOperador]) REFERENCES [dbo].[Operadores] ([intCodigo])
);

