SET DATEFORMAT DMY;

CREATE TABLE Rezervare
( 
  Id_rezervare INT CONSTRAINT pk_rezervare PRIMARY KEY,
  Id_client INT FOREIGN KEY REFERENCES Client(Id_client) ON DELETE CASCADE,
  Data_achizitie DATE NOT NULL,
  Metoda_achizitie VARCHAR(30) NOT NULL,
  CONSTRAINT metoda_invalida CHECK (Metoda_achizitie IN ('Cash', 'Online', 'Ordin plata')),
  Pret INT NOT NULL
    -- Se poate plati doar in Lei
)

CREATE SEQUENCE Id_rezervare_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1 NO CACHE  NO CYCLE;