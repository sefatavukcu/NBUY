CREATE DATABASE CompanyDatabase2Db
GO --veritaban� olu�mas� uzun s�rd���nden bunu diyoruz alt sat�ra olu�tuktan sonra ge�mesi i�in

USE CompanyDatabase2Db

CREATE TABLE Departmanlar(
	id int not null primary key identity(1,1),
	ad nvarchar(max) not null
)
--De�er ekleme
INSERT INTO	Departmanlar(ad) VALUES
	('Muhasebe'), 
	('Teknik'), 
	('Sat��'), 
	('�K'), 
	('Y�netim')

/*
	���i,Muhasebe Uzman�, Sat����, �K Uzman�, �K Stajyeri, Y�netici, Y�netici Yard�mc�s�
*/

CREATE TABLE Unvanlar(
	id int not null primary key identity(1,1),
	ad nvarchar(max) not null
)

INSERT INTO Unvanlar(ad) VALUES
	('���i'),
	('Muhasebe Uzman�'),
	('Sat����'),
	('�K Uzman�'),
	('�K Stajyeri'),
	('Y�netici'),
	('Y�netici Yard�mc�s�')

CREATE TABLE Iller(
	id char(2) not null primary key,
	ad nvarchar(30) not null
)

INSERT INTO Iller(id,ad) VALUES
	('34','�stanbul'),
	('06','Ankara'),
	('35','�zmir'),
	('17','�anakkale'),
	('41','Kocaeli')

CREATE TABLE Ilceler(
	id int not null primary key identity(1,1),
	ad nvarchar(30) not null,
	ilId char(2) not null,
	FOREIGN KEY(ilId) REFERENCES Iller(id)
)

INSERT INTO Ilceler(ad,ilId) VALUES
	('Kad�k�y','34'),
	('Be�ikta�','34'),
	('Konak','35'),
	('Biga','17'),
	('K�rfez','41'),
	('Mamak','06'),
	('�ankaya','06')

CREATE TABLE Personel(
	id int not null primary key identity(1,1),
	ad nvarchar(30) not null,
	soyad nvarchar(30) not null,
	cinsiyet bit not null,
	dogumTarihi date not null,
	ilceId int not null,
	iseBaslamaTarihi date not null,
	departmanId int not null,
	unvanId int not null,
	maas money not null,
	FOREIGN KEY(ilceId) REFERENCES Ilceler(id),
	FOREIGN KEY(departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId) REFERENCES Unvanlar(id)
)

INSERT INTO Personel(ad,soyad,cinsiyet,dogumTarihi,ilceId,iseBaslamaTarihi,departmanId,unvanId,maas) VALUES
	('Hasancan','G�zel',0,'1999-05-15',1,'2021-11-10',1,1,12500),
	('Ay�en','G�lce',1,'1999-05-15',2,'2021-11-10',5,2,14500),
	('Burak','Sever',0,'1999-05-15',3,'2021-11-10',4,2,19500),
	('Ali','�a�al',0,'1999-05-15',3,'2021-11-10',4,5,22500),
	('Fatih','Y�ld�z',0,'1999-05-15',4,'2021-11-10',3,7,9500),
	('Merve','Y�ld�z',1,'1999-05-15',5,'2021-11-10',2,6,15500),
	('Furkan','Kabak',0,'1999-05-15',6,'2021-11-10',1,4,18500),
	('Sema','�enocak',1,'1999-05-15',7,'2021-11-10',5,4,15500),
	('�enay','Ayten',1,'1999-05-15',7,'2021-11-10',3,1,15500)

CREATE TABLE Projeler(
	id int not null primary key identity(1,1),
	ad nvarchar(50) not null,
	baslamaTarihi date not null,
	planlananBitisTarihi date not null
)

INSERT INTO Projeler(ad, baslamaTarihi, planlananBitisTarihi) VALUES
	('Mutlu �ocuklar','2022-05-05','2022-05-05'),
	('Temiz �sk�dar','2022-05-05','2022-05-05'),
	('Kirli Kad�k�y','2022-05-05','2022-05-05'),
	('Haydi Gen�ler El Ele','2022-05-05','2022-05-05')