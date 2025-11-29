CREATE DATABASE Projekt_BD;

USE Projekt_BD;

CREATE TABLE Kody_pocztowe(
	kod_pocztowy VARCHAR(6) PRIMARY KEY,
	miasto VARCHAR(30)
);

CREATE TABLE Adresy (
    id INT PRIMARY KEY IDENTITY(1,1),
	kod_pocztowy VARCHAR(6),
    ulica VARCHAR(50),
    numer_budynku VARCHAR(10),
    numer_mieszkania VARCHAR(10),
	FOREIGN KEY (kod_pocztowy) REFERENCES Kody_pocztowe(kod_pocztowy)
);

CREATE TABLE Klient (
	id INT IDENTITY(1,1) PRIMARY KEY,
	imie VARCHAR(30),
	nazwisko VARCHAR(50),
	pesel VARCHAR(11),
	id_adresu INT NOT NULL,
	FOREIGN KEY (id_adresu) REFERENCES Adresy(id)
	);

CREATE TABLE Sprzet (
	id INT IDENTITY(1,1) PRIMARY KEY,
	typ VARCHAR(20) NOT NULL,
	marka VARCHAR(30) NOT NULL,
	rozmiar INT NOT NULL,
	data_zakupu DATE DEFAULT GETDATE(),
	koszt_wypozyczenia INT NOT NULL,
	);

CREATE TABLE Wypozyczenia(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_klienta INT NOT NULL,
	id_sprzetu INT NOT NULL,
	data_wypoz DATE DEFAULT GETDATE(),
	okres_wypoz INT DEFAULT 1,
	FOREIGN KEY (id_klienta) REFERENCES Klient(id),
	FOREIGN KEY (id_sprzetu) REFERENCES Sprzet(id)
	);
CREATE TABLE Urzytkownicy(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nazwa VARCHAR(35) NOT NULL,
	haslo VARCHAR(512) NOT NULL
	)