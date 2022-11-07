use Northwind
--Products tablosunun unitpricekolonuna g�re b�y�kten k����e s�rala

--select * from Products order by unitPrice DESC

--select * from Products order by UnitPrice 

--unitprice 100 �zerinde olanlar� g�steriniz

--select * from Products where UnitPrice>100

-- kategorisi 7 ve 8 olan �r�nleri listeleyiniz.

--select * from Products where CategoryID=8 or CategoryID=7

--kategorisi 7 ve 8 olanlardan stok miktar� 10dan d���k olan �r�nleri listeleyiniz

--select * from Products where (CategoryID=8 or CategoryID=7) and UnitsInStock<=10 

--kategorisi 7 ve 8 olanlardan stok miktar� 10dan d���k olan �r�nlerin say�s�
--select count(*) from Products where (CategoryID=8 or CategoryID=7) and UnitsInStock<=10

-----INNER JOIN-----
--select Products.ProductName,Categories.CategoryName from Products inner join Categories
--	on Products.CategoryID=Categories.CategoryID

-- k�saltma hali harf tan�ml�yoruz.
--select P.ProductName,C.CategoryName 
--from Products P inner join Categories C
--on P.CategoryID=C.CategoryID

--select P.ProductName,C.CategoryName, P.UnitPrice
--from Products P inner join Categories C
--on P.CategoryID=C.CategoryID
--where CategoryName='Beverages' and P.UnitPrice<=40
--order by P.UnitPrice desc

---Product Name ve Supplier Company Name g�steren bir sorgu yaz�n�z.

--select P.ProductName,S.CompanyName
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID

--Germany den tedarik edilen �r�nlerin Product name listesi

--select P.ProductName,S.Country
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID
--where Country='Germany'

----Germany den tedarik edilen �r�nlerin toplam tutar�

--select sum(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar' 
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID
--where Country='Sweden'

-------Chai sat��lar�n�n toplam tutar�
--select sum(OD.UnitPrice * OD.Quantity) as 'Toplam Tutar' 
--from Products P inner join [Order Details] OD
--on P.ProductID=OD.ProductID
--where p.ProductName='Chai'


-----Germanye yap�lm�� Chai sat��lar�n�n toplam tutar�
--select sum(OD.UnitPrice * Od.Quantity) as 'Toplam Tutar' 
--from Orders O inner join [Order Details] OD
--on O.OrderID=OD.OrderID inner join Products P
--on OD.ProductID = P.ProductID
--where O.ShipCountry='Germany' and P.ProductName='Chai'


--- Ernst Handel m��terisine yap�lan sat�� tutar�n�n toplam�
select sum(OD.UnitPrice * OD.Quantity)
from [Order Details] OD inner join Orders O
on OD.OrderID = O.OrderID inner join Customers C
on O.CustomerID=C.CustomerID
where c.CompanyName='Ernst Handel'
