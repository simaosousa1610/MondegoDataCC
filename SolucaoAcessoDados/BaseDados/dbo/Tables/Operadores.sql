CREATE TABLE [dbo].[Operadores] (
    [intCodigo]       INT           IDENTITY (1, 1) NOT NULL,
    [strNome]         NVARCHAR (50) NOT NULL,
    [strPasswordHash] BINARY (64)   NOT NULL,
    [fltPrecoHora]    FLOAT (53)    NOT NULL,
    [bitAtivo]        BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([intCodigo] ASC)
);

