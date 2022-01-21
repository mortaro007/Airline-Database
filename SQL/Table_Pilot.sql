SET DATEFORMAT DMY;

CREATE TABLE Pilot
( 
  Id_pilot INT CONSTRAINT pk_pilot PRIMARY KEY,
  Id_aeronava BIGINT FOREIGN KEY REFERENCES Aeronava(Id_aeronava)
  ON DELETE SET NULL,
  Nume VARCHAR(25) NOT NULL,
  Prenume VARCHAR(25) NOT NULL,
  Gen VARCHAR(2) NOT NULL,
  CONSTRAINT gen_invalid CHECK (Gen in ('F', 'M','f', 'm')),
  Data_nastere DATE NOT NULL,
  CNP BIGINT  CONSTRAINT cnpul_invalid UNIQUE NOT NULL, 
  CONSTRAINT cnp_incorect CHECK (CNP >= 1000000000000),
  Data_angajare DATE NOT NULL, 
  CONSTRAINT date_incorecte CHECK (Data_angajare > Data_nastere),
  Nr_telefon VARCHAR(15) NOT NULL,
  CONSTRAINT telefon_pilot_invalid CHECK ( LEN(Nr_telefon)>9 and LEN(Nr_telefon)<16),
)

CREATE SEQUENCE Id_pilot_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1000  NO CACHE  NO CYCLE;