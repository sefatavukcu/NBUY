USE master
go

DROP DATABASE IF EXISTS HastaneDb -- hastane veritaban� varsa ilk �nce siler sonra tekrar olu�turur.
GO


CREATE DATABASE HastaneDb
GO
-------------------------------------------

USE HastaneDb 
GO

CREATE TABLE Hastalar(
	id int not null primary key identity(1,1),
	adSoyad nvarchar(50) not null,
	cinsiyet char(1) not null,
	adres nvarchar(50),
	telefon char(11)
)
GO

-- Hastalar Tablosu
insert into Hastalar(adSoyad,cinsiyet,adres) values
	('Ali Akman','E','�stanbul'),
	('Selin Fergen�','K','Ankara'),
	('Sadi Kulo�lu','E','�zmir'),
	('Ne�e Kalabal�k','K','�stanbul'),
	('Sevda A�alar','K','�zmir'),
	('Nora Ta�kesen','K','Ankara'),
	('Emma Kilim','K','�stanbul'),
	('Kerem S�zc�','E','�stanbul'),
	('Suat Tartar','E','Ankara')
Go

-- B�l�mler Tablosu
create table Bolumler(
	id int not null primary key identity(1,1),
	ad nvarchar(30) not null
)

insert into Bolumler values 
	('Dahiliye'),('N�roloji'),('Ortopedi'),
	('Di�'),('Periodontoloji'),('Genel Cerrahi')
GO

--Doktorlar Tablosu
create table Doktorlar(
	id int not null primary key identity(1,1),
	adSoyad nvarchar(50) not null,
	adres nvarchar(50),
	bolumId int,
	foreign key(bolumId) REFERENCES Bolumler(id)
)
GO

insert into Doktorlar values
	('Ali Can','�stanbul',1),
	('Demet Evgar','Bursa',2),
	('Sedat Kanar','�zmir',3),
	('Ferhunde Han�m','Ankara',3),
	('Zafer Kimki','�anakkale',1),
	('Hale Elveren','�stanbul',2),
	('Tuna Sefer','Ankara',4),
	('Tuna Sefer','Konya',4),
	('Kevser Tutku','�stanbul',5),
	('Tutkum Kap��mak','�zmir',5),
	('�sa Canova','�stanbul',1),
	('Tu��e B�l�ms�z','Ankara',null)
GO

--Yukar�daki insert into nun son sat�r�n�n alternatifi buras�:

--insert into Doktorlar (adSoyad,adres) values
--	('Tu��e B�l�ms�z','Ankara')
--GO

