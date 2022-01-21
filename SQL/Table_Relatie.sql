CREATE TABLE Ruta_Aeroport
(
  Id_ruta INT foreign key references Ruta(Id_ruta) NOT NULL,
  Cod_aeroport varchar(3) foreign key references Aeroport(Cod_aeroport) NOT NULL,
  --ALTER TABLE ADD PRIMARY KEY(Id_ruta, Cod_aeroport)
  CONSTRAINT PK_Ruta_Aeroport Primary Key (Id_ruta, Cod_aeroport)
)