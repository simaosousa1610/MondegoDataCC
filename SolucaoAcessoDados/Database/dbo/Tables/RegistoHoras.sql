CREATE TABLE [dbo].[RegistoHoras] (
    [intCodigo]     INT        IDENTITY (1, 1) NOT NULL,
    [intOperador]   INT        NOT NULL,
    [dtmInicio]     DATETIME   NOT NULL,
    [dtmFim]        DATETIME   NOT NULL,
    [fltPrecoHora]  FLOAT (53) NOT NULL,
    [fltPrecoTotal] FLOAT (53) NOT NULL,
    [bitValidado]   BIT        NOT NULL,
    [bitAtivo]      BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([intCodigo] ASC),
    FOREIGN KEY ([intOperador]) REFERENCES [dbo].[Operadores] ([intCodigo])
);

