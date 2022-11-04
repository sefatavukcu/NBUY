USE SampleDb

CREATE TABLE Calisanlar(
	id int not null identity(1,1),
	tcNo char(11) not null,
	adSoyad NVARCHAR(50) not null,
	cinsiyet bit not null,
	bolumId INT NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(bolumId) REFERENCES Bolumler(id)  -- bire çok iliþki kuruldu.
)

--DROP TABLE Calisanlar