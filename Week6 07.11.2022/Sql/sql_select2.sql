use KutuphaneDb

-- sayfa sayýsý 300den büyük olan kitaplarý listeleyin

--select * from Kitaplar where sayfaSayisi>300

-- stok adedi 90-113 arasý kitaplar

--select * from Kitaplar where stok>=90 and stok<=113
--select * from Kitaplar where stok between 90 and 113

--select * from kitaplar order by sayfaSayisi desc

-- türe göre küçükten büyüðe
--select * from kitaplar order by turId,sayfaSayisi desc

--HESAPLAMA 
--select * from Kitaplar
--select min(sayfaSayisi) as 'En az sayfa sayýsý' from Kitaplar  -- en küçük deðeri bulan fonksiyon
--select max(sayfaSayisi) as 'En yüksek sayfa sayýsý' from Kitaplar
--select count(*) from Kitaplar  
--select AVG(sayfaSayisi) from Kitaplar  -- ortalama
--select sum(stok) from Kitaplar -- toplam
--select sum(stok*sayfaSayisi) from Kitaplar 

----------update-----------------

--update Kitaplar set sayfaSayisi = sayfaSayisi *1.2

