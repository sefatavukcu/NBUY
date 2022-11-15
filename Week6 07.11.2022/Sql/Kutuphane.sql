/*
1) KutuphaneDb adýnda bir veri tabaný oluþturun.
2) Veritabanýnda aþaðýdaki tablolar bulunsun:
	Turler (id,ad)
	Yazarlar (ad soyad cinsiyet yas)
	Yayýnevleri (ad adres)
	Uyeler (ad soyad yas cinsiyet )
	Kitaplar (ad yazar yayýnevi tür)
	OduncÝslemleri (üyead, )

3) yeteri kadar örnek veri giriþi yapýnýz.
yazarýn birden fazla kitabý olabilir
yayýn evinde birden çok kitap olabilir

------on delete cascade: sildirmez
------ turId int default 1 ........ on delete set default: Siler ama default olarak tanýmlanan rakamý atar
------Ýçinde tabloda turId kýsmýna girip allow nulls iþaretli olmasý lazým ve içeriðine default kýsmýný 1 yapýlmasý lazým

------turId int ....... on delete set null
------veri silindiði zaman null olarak atar
------

*/

USE master
go

DROP DATABASE IF EXISTS KutuphaneDb -- hastane veritabaný varsa ilk önce siler sonra tekrar oluþturur.
GO


CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb 
GO

create table Turler(
	id int not null primary key identity(1,1),
	ad nvarchar(20) not null
)
GO

insert into Turler Values
	('Macera'),
	('Romantik'),
	('Bilim-Kurgu'),
	('Polisiye'),
	('Aksiyon'),
	('Tarih')
GO


create table Yazarlar(
	id int not null primary key identity(1,1),
	adSoyad nvarchar(50) not null,
	cinsiyet char(1) not null,
	yas int not null
)
GO

insert into Yazarlar Values
	('Hasan Can','E',29),
	('Ayþen Ece','K',36),
	('Merve Duman','K',42),
	('Onur Kemal','E',34),
	('Furkan Yýldýrým','E',39),
	('Feyza Sümer','K',49)
GO

create table Yayinevleri(
	id int not null primary key identity(1,1),
	ad nvarchar(50) not null,
	adres nvarchar(30) not null
)
GO

insert into Yayinevleri Values
	('Pelikan','Ýstanbul'),
	('Morpa','Ankara'),
	('FEM','Ýstanbul'),
	('Kýrmýzý Kedi','Sakarya'),
	('Platanus','Ýzmir'),
	('D&R','Ankara')
GO

create table Uyeler(
	id int not null primary key identity(1,1),
	adSoyad nvarchar(50) not null,
	cinsiyet char(1) not null,
	yas int not null,
)
GO

insert into Uyeler Values
	('Engin Kemal','E',36),
	('Gülce Çakmak','K',19),
	('Gülçin Cemal','K',42),
	('Murat Uysal','E',47),
	('Hasan Sezgin','E',22),
	('Senem Kumar','K',49),
	('Fatih Terim','E',63),
	('Okan Buruk','E',49),
	('Esra Keser','K',29)
GO

create table Kitaplar(
	id int not null primary key identity(1,1),
	ad nvarchar(50) not null,
	yazarId int not null,
	yayineviId int not null,
	foreign key(yazarId) REFERENCES Yazarlar(id),
	foreign key(yayineviId) REFERENCES Yayinevleri(id),
)

GO

insert into Kitaplar values
	('Antika Titanik',3,1),
	('Babamýn Yeri',2,1),
	('1984',4,2),
	('Devlet Ana',5,5),
	('Hayvan Çiftliði',5,3),
	('Sefiller',6,1),
	('Sherlock Holmes',6,3),
	('Harry Potter',4,5),
	('Savaþ Atý',1,5),
	('Ruhi Mücerret',1,2),
	('Korkma Ben Varým',2,6),
	('Camdaki Kýz',2,4),
	('Nutuk',3,4)
GO

create table KitapTur(
	kitapId int not null,
	turId int not null,
	foreign key(kitapId) references Kitaplar(id),
	foreign key(turId) references Turler(id)
)
GO

insert into KitapTur values
	(1,1),
	(1,2),
	(1,6),
	(2,2),
	(2,4),
	(3,2),
	(4,6),
	(4,5),
	(5,2),
	(5,1),
	(6,4),
	(7,3),
	(7,5),
	(8,2),
	(9,6),
	(9,3),
	(10,2),
	(11,4),
	(11,6),
	(12,1),
	(13,2),
	(13,5)
GO

create table OduncÝslemleri(
	id int not null primary key identity(1,1),
	uyeId int not null,
	kitapId int not null,
	tarih date not null,
	foreign key(uyeId) references Uyeler(id),
	foreign key(kitapId) references Kitaplar(id)
)
GO

insert into OduncÝslemleri values
	(1,1,'2022-03-06'),
	(1,2,'2022-07-05'),
	(3,12,'2021-07-19'),
	(4,10,'2022-05-01'),
	(4,7,'2022-06-29'),
	(6,5,'2022-03-11'),
	(2,1,'2022-01-01')
GO