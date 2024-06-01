CREATE TABLE [dbo].[Table]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [paciente_nombre] VARCHAR(50) NULL,
	[paciente_apellido] VARCHAR(50) NULL, 
    [paciente_sexo] VARCHAR(10) NULL, 
    [paciente_direccion] VARCHAR(100) NULL, 
    [paciente_edad] TINYINT NULL, 
    [paciente_edificio] VARCHAR(50) NULL, 
    [paciente_estado] VARCHAR(50) NULL
    
)
