use KutuphaneDb

-- sayfa say�s� 300den b�y�k olan kitaplar� listeleyin

--select * from Kitaplar where sayfaSayisi>300

-- stok adedi 90-113 aras� kitaplar

--select * from Kitaplar where stok>=90 and stok<=113
--select * from Kitaplar where stok between 90 and 113

--select * from kitaplar order by sayfaSayisi desc

-- t�re g�re k���kten b�y��e
--select * from kitaplar order by turId,sayfaSayisi desc

--HESAPLAMA 
--select * from Kitaplar
--select min(sayfaSayisi) as 'En az sayfa say�s�' from Kitaplar  -- en k���k de�eri bulan fonksiyon
--select max(sayfaSayisi) as 'En y�ksek sayfa say�s�' from Kitaplar
--select count(*) from Kitaplar  
--select AVG(sayfaSayisi) from Kitaplar  -- ortalama
--select sum(stok) from Kitaplar -- toplam
--select sum(stok*sayfaSayisi) from Kitaplar 

----------update-----------------

--update Kitaplar set sayfaSayisi = sayfaSayisi *1.2

