use HastaneDb
--select * from Bolumler 

--use HastaneDb
--select * from Doktorlar 

--use HastaneDb
--select adSoyad as 'Ad Soyad', adres as 'ADRES' from Doktorlar 

------F�LTRELEME--------------

--select * from Doktorlar where id=5
--select * from Doktorlar where adSoyad='Tuna Sefer'
--select * from Doktorlar where adSoyad!='Tuna Sefer'
--select * from Doktorlar where id=3 or id=6
--select * from Doktorlar where not adSoyad='Tuna Sefer'
--select * from Doktorlar where bolumId=5 and adres='�zmir'
--select * from Doktorlar where id>=6

--select * from Doktorlar where adres in ('Ankara','�stanbul')
--select * from Doktorlar where adSoyad LIKE 'Tut%'  -- ne ile ba�l�yor
--select * from Doktorlar where adSoyad LIKE '%r'   --- ne ile bitiyor
--select * from Doktorlar where adSoyad LIKE '%s%'  --- i�ine ge�en
--select * from Doktorlar where adSoyad LIKE '_e%'    --- ikinci harfi 
--select * from Doktorlar where adSoyad LIKE 'D_m%'  --- ilk harfi d ���nc� harfi e


---------SIRALAMA---------
--select * from Doktorlar order by adSoyad -- s�ralama
--select * from Doktorlar order by adSoyad desc -- ters s�ralama alfabeye g�re
--select * from Doktorlar order by bolumId  -- s�ralama numara
--select * from Doktorlar order by bolumId desc -- ters s�ralama numara
--select * from Doktorlar order by adres  -- s�ralama 
--select * from Doktorlar order by adres, adSoyad  -- s�ralama ve kendi i�inde tekrar s�ralama

--select count(*) from Doktorlar
--select count(bolumId) from Doktorlar  -- kolondakidolu olanlar� getirir.

--STRING--
--select len('Sefa Tavuk�u') --karakter uzunlu�u
--select adSoyad,len(adSoyad) as uzunluk from Doktorlar
--select 
--adSoyad, left(adSoyad,3) as '�lk �� karakter', 
--len(adSoyad) as 'Uzunluk'
--from Doktorlar

--select
--	adSoyad, upper(adSoyad) as 'B�y�k',
--	lower(adSoyad) as 'K���k'
--from Doktorlar

--select
--	replace('Sefa Tavukcu','u','Merhaba')  -- istenilen karakter yerine ba�ka bir�ey koyuyoruz.

--select 
--	lower(replace('Sefa Tavukcu',' ','')) + '@gmail.com'

--select
--	adSoyad,
--		replace(lower(adSoyad),' ','') + '@gmail.com' as 'Mail Adresi'
--from Doktorlar

--------------------------------------------------------------------------------------------------

-- Sercan Furkan ad�nda, Amasya'da ya�ayan, b�l�m� 3 olan doktoru kaydedecek sorguyu yaz�n�z

--insert into Doktorlar (adSoyad, adres, bolumId) values
--	('Sercan Furkan', 'Amasya',3)

---------G�NCELLEME---------------------------------------------

--update Doktorlar set adSoyad='Sercan Ahmet Furkan'
--where id=12  -- e�er bu sat�r girilmezse yani ko�ul, t�m veriler yukar�daki isim gibi olur.


-------------S�LME-------------------

--delete from Doktorlar where id=6

--delete from Doktorlar where bolumId is null --null silme

