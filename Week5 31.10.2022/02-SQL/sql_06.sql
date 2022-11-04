CREATE DATABASE CompanyDatabase2Db
GO --veritabaný oluþmasý uzun sürdüðünden bunu diyoruz alt satýra oluþtuktan sonra geçmesi için

USE CompanyDatabase2Db

CREATE TABLE Departmanlar(
	id int not null primary key identity(1,1),
	ad nvarchar(max) not null
)
--Deðer ekleme
INSERT INTO	Departmanlar(ad) VALUES
	('Muhasebe'), 
	('Teknik'), 
	('Satýþ'), 
	('ÝK'), 
	('Yönetim')

/*
	Ýþçi,Muhasebe Uzmaný, Satýþçý, ÝK Uzmaný, ÝK Stajyeri, Yönetici, Yönetici Yardýmcýsý
*/

CREATE TABLE Unvanlar(
	id int not null primary key identity(1,1),
	ad nvarchar(max) not null
)

INSERT INTO Unvanlar(ad) VALUES
	('Ýþçi'),
	('Muhasebe Uzmaný'),
	('Satýþçý'),
	('ÝK Uzmaný'),
	('ÝK Stajyeri'),
	('Yönetici'),
	('Yönetici Yardýmcýsý')

CREATE TABLE Iller(
	id char(2) not null primary key,
	ad nvarchar(30) not null
)

INSERT INTO Iller(id,ad) VALUES
	('34','Ýstanbul'),
	('06','Ankara'),
	('35','Ýzmir'),
	('17','Çanakkale'),
	('41','Kocaeli')

CREATE TABLE Ilceler(
	id int not null primary key identity(1,1),
	ad nvarchar(30) not null,
	ilId char(2) not null,
	FOREIGN KEY(ilId) REFERENCES Iller(id)
)

INSERT INTO Ilceler(ad,ilId) VALUES
	('Kadýköy','34'),
	('Beþiktaþ','34'),
	('Konak','35'),
	('Biga','17'),
	('Körfez','41'),
	('Mamak','06'),
	('Çankaya','06')

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
	('Hasancan','Güzel',0,'1999-05-15',1,'2021-11-10',1,1,12500),
	('Ayþen','Gülce',1,'1999-05-15',2,'2021-11-10',5,2,14500),
	('Burak','Sever',0,'1999-05-15',3,'2021-11-10',4,2,19500),
	('Ali','Þaþal',0,'1999-05-15',3,'2021-11-10',4,5,22500),
	('Fatih','Yýldýz',0,'1999-05-15',4,'2021-11-10',3,7,9500),
	('Merve','Yýldýz',1,'1999-05-15',5,'2021-11-10',2,6,15500),
	('Furkan','Kabak',0,'1999-05-15',6,'2021-11-10',1,4,18500),
	('Sema','Þenocak',1,'1999-05-15',7,'2021-11-10',5,4,15500),
	('Þenay','Ayten',1,'1999-05-15',7,'2021-11-10',3,1,15500)

CREATE TABLE Projeler(
	id int not null primary key identity(1,1),
	ad nvarchar(50) not null,
	baslamaTarihi date not null,
	planlananBitisTarihi date not null
)

INSERT INTO Projeler(ad, baslamaTarihi, planlananBitisTarihi) VALUES
	('Mutlu Çocuklar','2022-05-05','2022-05-05'),
	('Temiz Üsküdar','2022-05-05','2022-05-05'),
	('Kirli Kadýköy','2022-05-05','2022-05-05'),
	('Haydi Gençler El Ele','2022-05-05','2022-05-05')