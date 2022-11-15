USE master
go

DROP DATABASE IF EXISTS HastaneDb -- hastane veritabaný varsa ilk önce siler sonra tekrar oluþturur.
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
	('Ali Akman','E','Ýstanbul'),
	('Selin Fergenç','K','Ankara'),
	('Sadi Kuloðlu','E','Ýzmir'),
	('Neþe Kalabalýk','K','Ýstanbul'),
	('Sevda Aðalar','K','Ýzmir'),
	('Nora Taþkesen','K','Ankara'),
	('Emma Kilim','K','Ýstanbul'),
	('Kerem Sözcü','E','Ýstanbul'),
	('Suat Tartar','E','Ankara')
Go

-- Bölümler Tablosu
create table Bolumler(
	id int not null primary key identity(1,1),
	ad nvarchar(30) not null
)

insert into Bolumler values 
	('Dahiliye'),('Nöroloji'),('Ortopedi'),
	('Diþ'),('Periodontoloji'),('Genel Cerrahi')
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
	('Ali Can','Ýstanbul',1),
	('Demet Evgar','Bursa',2),
	('Sedat Kanar','Ýzmir',3),
	('Ferhunde Haným','Ankara',3),
	('Zafer Kimki','Çanakkale',1),
	('Hale Elveren','Ýstanbul',2),
	('Tuna Sefer','Ankara',4),
	('Tuna Sefer','Konya',4),
	('Kevser Tutku','Ýstanbul',5),
	('Tutkum Kapýþmak','Ýzmir',5),
	('Ýsa Canova','Ýstanbul',1),
	('Tuðçe Bölümsüz','Ankara',null)
GO

--Yukarýdaki insert into nun son satýrýnýn alternatifi burasý:

--insert into Doktorlar (adSoyad,adres) values
--	('Tuðçe Bölümsüz','Ankara')
--GO

