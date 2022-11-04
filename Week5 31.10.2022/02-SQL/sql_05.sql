/*
	Satis Bilgiler
*/

CREATE TABLE Satislar(
	id int not null primary key identity(1,1),
	urunId int not null,
	calisanId int not null,
	adet int not null,
	fiyat money not null,
	tarih datetime not null,
	FOREIGN KEY(urunId) REFERENCES UrunlerTablosu(id),
	FOREIGN KEY(calisanId) REFERENCES Calisanlar(id)
)

-- datetime: YYYY-AA-GG