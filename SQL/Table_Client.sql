SET DATEFORMAT DMY;

CREATE TABLE Client
(
  Id_client INT CONSTRAINT pk_client PRIMARY KEY,  
  Nume VARCHAR(25) NOT NULL,   
  Prenume VARCHAR(25) NOT NULL,
  Gen VARCHAR(2) NOT NULL,
  CONSTRAINT gen_invalid_FsauM CHECK (Gen in ('F', 'M','f', 'm')),
  Data_nasterii DATE NOT NULL,
  CNP BIGINT  CONSTRAINT cnp_deja_utilizat UNIQUE NOT NULL, 
  CONSTRAINT cnp_invalid CHECK (CNP >= 1000000000000),
    -- Nume insotitor se completeaza doar in cazurile persoanelor sub 18 ani (minor). 
  Nume_insotitor VARCHAR(52),
  Tara VARCHAR(25) NOT NULL,
  Regiune VARCHAR(25) NOT NULL,
  Localitate VARCHAR(25) NOT NULL, 
  Strada VARCHAR(25) NOT NULL,
  Numar VARCHAR(4),
    -- Numarul este varchar deoarece exista adrese ca Strada Mihai Kogalniceanu, Nr. 120C
  Nr_telefon VARCHAR(15) NOT NULL,
  CONSTRAINT telefon_client_invalid CHECK ( LEN(Nr_telefon)>9 and LEN(Nr_telefon)<16),
  Adresa_mail VARCHAR(50) NOT NULL
)

CREATE SEQUENCE Id_client_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 100  NO CACHE  NO CYCLE;