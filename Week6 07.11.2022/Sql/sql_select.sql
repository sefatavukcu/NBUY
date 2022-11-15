use HastaneDb
--select * from Bolumler 

--use HastaneDb
--select * from Doktorlar 

--use HastaneDb
--select adSoyad as 'Ad Soyad', adres as 'ADRES' from Doktorlar 

------FÝLTRELEME--------------

--select * from Doktorlar where id=5
--select * from Doktorlar where adSoyad='Tuna Sefer'
--select * from Doktorlar where adSoyad!='Tuna Sefer'
--select * from Doktorlar where id=3 or id=6
--select * from Doktorlar where not adSoyad='Tuna Sefer'
--select * from Doktorlar where bolumId=5 and adres='Ýzmir'
--select * from Doktorlar where id>=6

--select * from Doktorlar where adres in ('Ankara','Ýstanbul')
--select * from Doktorlar where adSoyad LIKE 'Tut%'  -- ne ile baþlýyor
--select * from Doktorlar where adSoyad LIKE '%r'   --- ne ile bitiyor
--select * from Doktorlar where adSoyad LIKE '%s%'  --- içine geçen
--select * from Doktorlar where adSoyad LIKE '_e%'    --- ikinci harfi 
--select * from Doktorlar where adSoyad LIKE 'D_m%'  --- ilk harfi d üçüncü harfi e


---------SIRALAMA---------
--select * from Doktorlar order by adSoyad -- sýralama
--select * from Doktorlar order by adSoyad desc -- ters sýralama alfabeye göre
--select * from Doktorlar order by bolumId  -- sýralama numara
--select * from Doktorlar order by bolumId desc -- ters sýralama numara
--select * from Doktorlar order by adres  -- sýralama 
--select * from Doktorlar order by adres, adSoyad  -- sýralama ve kendi içinde tekrar sýralama

--select count(*) from Doktorlar
--select count(bolumId) from Doktorlar  -- kolondakidolu olanlarý getirir.

--STRING--
--select len('Sefa Tavukçu') --karakter uzunluðu
--select adSoyad,len(adSoyad) as uzunluk from Doktorlar
--select 
--adSoyad, left(adSoyad,3) as 'Ýlk üç karakter', 
--len(adSoyad) as 'Uzunluk'
--from Doktorlar

--select
--	adSoyad, upper(adSoyad) as 'Büyük',
--	lower(adSoyad) as 'Küçük'
--from Doktorlar

--select
--	replace('Sefa Tavukcu','u','Merhaba')  -- istenilen karakter yerine baþka birþey koyuyoruz.

--select 
--	lower(replace('Sefa Tavukcu',' ','')) + '@gmail.com'

--select
--	adSoyad,
--		replace(lower(adSoyad),' ','') + '@gmail.com' as 'Mail Adresi'
--from Doktorlar

--------------------------------------------------------------------------------------------------

-- Sercan Furkan adýnda, Amasya'da yaþayan, bölümü 3 olan doktoru kaydedecek sorguyu yazýnýz

--insert into Doktorlar (adSoyad, adres, bolumId) values
--	('Sercan Furkan', 'Amasya',3)

---------GÜNCELLEME---------------------------------------------

--update Doktorlar set adSoyad='Sercan Ahmet Furkan'
--where id=12  -- eðer bu satýr girilmezse yani koþul, tüm veriler yukarýdaki isim gibi olur.


-------------SÝLME-------------------

--delete from Doktorlar where id=6

--delete from Doktorlar where bolumId is null --null silme

