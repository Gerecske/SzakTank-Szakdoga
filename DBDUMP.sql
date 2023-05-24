﻿CREATE DATABASE [SzakTank];

USE [SzakTank];

CREATE TABLE Jatekos (
	Felhasznalonev VARCHAR(30) NOT NULL,
	Jelszo BINARY(64) NOT NULL,
	Szin INT NOT NULL
	PRIMARY KEY (Felhasznalonev)
);

CREATE TABLE Terkep (
	TerkepID INT NOT NULL IDENTITY,
	Nev VARCHAR(120),
	TerkepMap INT,
	Pont INT,
	PRIMARY KEY (TerkepID)
);

CREATE TABLE Lepesek (
	LepesID INT NOT NULL IDENTITY,
	TerkepID INT NOT NULL,
	Felhasznalonev VARCHAR(30) NOT NULL,
	Lepes VARCHAR(120) NOT NULL
	PRIMARY KEY (LepesID)
);

CREATE TABLE Jatek (
	JatekID INT NOT NULL IDENTITY,
	TerkepID INT NOT NULL,
	Felhasznalonev VARCHAR(30) NOT NULL,
	Pont INT NOT NULL,
	PRIMARY KEY (JatekID)
);