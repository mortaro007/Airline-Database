CREATE TABLE Bilet
(
  Id_bilet INT CONSTRAINT pk_bileT PRIMARY KEY,
  Id_rezervare INT FOREIGN KEY REFERENCES Rezervare(Id_rezervare),
  Id_zbor INT FOREIGN KEY REFERENCES Zbor(Id_zbor),
  Nr_loc VARCHAR(3) NOT NULL,
  Tip_bilet VARCHAR(20) NOT NULL,
  CONSTRAINT tip_bilet_invalid CHECK (Tip_bilet IN ('Standard', 'Express', 'Comfort'))
)

CREATE SEQUENCE Id_bilet_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1 NO CACHE  NO CYCLE;
