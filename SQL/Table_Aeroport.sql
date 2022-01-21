SET DATEFORMAT DMY;

CREATE TABLE Aeroport
(
  Cod_aeroport VARCHAR(3)  PRIMARY KEY,
  Nume_aeroport VARCHAR(50) CONSTRAINT nume_unic UNIQUE NOT NULL,
  Tara VARCHAR(20)  NOT NULL ,
  CONSTRAINT servicii_indisponibile_in_aceasta_tara CHECK (Tara IN ('Romania', 'Italia', 'Grecia', 'Germania', 
  'Spania', 'Cipru', 'Regatul Unit', 'Franta', 'Portugalia', 'Olanda', 'Danemarca', 'Turcia')),
  Regiune VARCHAR(20) NOT NULL,
  CONSTRAINT locatie_invalida CHECK (Regiune IN ('Bucuresti', 'Iasi', 'Cluj', 'Bacau', 'Roma', 'Napoli', 
  'Milano', 'Torino', 'Atena', 'Salonic', 'Corfu', 'Berlin', 'Stuttgard', 'Barcelona', 'Valencia', 'Madrid', 'Larnaca',
  'Londra', 'Liverpool', 'Lion', 'Paris', 'Lisabona', 'Amsterdam', 'Copenhaga', 'Istanbul', 'Antalya')),
  Localitate VARCHAR(20) NOT NULL,
  Strada VARCHAR(50) NOT NULL,
  Nr VARCHAR(10),
	-- Numarul este varchar deoarece exista adrese ca Strada Mihai Eminescu, Nr. 10B | Poate fi null pentru exista adrese ca Bacau, Loc. Buhoci (fara numarul casei specificat)
  Nr_telefon VARCHAR(15) UNIQUE NOT NULL
  CONSTRAINT nr_tel_invalid CHECK ( LEN(Nr_telefon)>9 and LEN(Nr_telefon)<16)
)