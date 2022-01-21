SET DATEFORMAT DMY;

CREATE TABLE Zbor
( 
  Id_zbor INT,
  Id_aeronava BIGINT FOREIGN KEY REFERENCES Aeronava(Id_aeronava),
  Id_ruta INT FOREIGN KEY REFERENCES Ruta(Id_ruta),
  Data_zbor DATE NOT NULL,
  Ora_decolare TIME NOT NULL,
  Ora_aterizare TIME NOT NULL,
  PRIMARY KEY(Id_zbor),
  CONSTRAINT ora_incorecta CHECK (Ora_decolare < Ora_aterizare)
)

CREATE SEQUENCE Id_zbor_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1001  NO CACHE  NO CYCLE;