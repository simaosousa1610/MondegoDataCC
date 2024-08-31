CREATE TABLE [dbo].[Aplicacao] (
    [intCodigo] INT           IDENTITY (1, 1) NOT NULL,
    [strNome]   NVARCHAR (30) NOT NULL,
    [bitAtivo]  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([intCodigo] ASC)
);

