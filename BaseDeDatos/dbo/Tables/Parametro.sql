﻿CREATE TABLE [dbo].[Parametro]
(
	
	IdParametro INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Parametro PRIMARY KEY CLUSTERED(IdParametro), 
	Codigo VARCHAR(250) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
	Valor INT NOT NULL,
	Estado VARCHAR(250) NOT NULL,


)
WITH (DATA_COMPRESSION = PAGE)
GO