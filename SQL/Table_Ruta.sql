CREATE TABLE Ruta  
( 
  Id_ruta INT CONSTRAINT pk_ruta PRIMARY KEY,
  Cod_plecare VARCHAR(3) ,
  Cod_destinatie VARCHAR(3),
  CONSTRAINT ruta_invalida CHECK (Cod_destinatie <> Cod_plecare)
)