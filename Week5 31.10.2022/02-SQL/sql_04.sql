/*
	Urunler tablosu
	-id
	-ad
	-stokMiktari
	-fiyat
*/

CREATE TABLE UrunlerTablosu(
	id int not null PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	stokMiktari int not null,
	fiyat money not null
)