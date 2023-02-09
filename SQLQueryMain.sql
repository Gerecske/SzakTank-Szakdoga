CREATE TABLE Jatekos (
	Felhasznalonev VARCHAR(30) NOT NULL,
	Jelszo BINARY(64) NOT NULL,
	Szin INT NOT NULL
	PRIMARY KEY (Felhasznalonev)
);

CREATE TABLE Terkep (
	TerkepID INT NOT NULL IDENTITY,
	Nev VARCHAR(30),
	TerkepMap INT,
	Pont INT,
	PRIMARY KEY (TerkepID)
);

CREATE TABLE Jatszma(
	JatszmaID INT NOT NULL IDENTITY,
	JatekosStatsID INT NOT NULL,
	TerkepID INT NOT NULL,
	PRIMARY KEY (JatszmaID)
);

CREATE TABLE JatekosStats(
	JatekosStatsID INT NOT NULL IDENTITY,
	Felhasznalonev VARCHAR(30) NOT NULL,
	Moves INT,
	Pontszam INT,
	Gyoztes BIT,
	PRIMARY KEY (JatekosStatsID)
);