use Northwind
--Products tablosunun unitpricekolonuna göre büyükten küçüðe sýrala

--select * from Products order by unitPrice DESC

--select * from Products order by UnitPrice 

--unitprice 100 üzerinde olanlarý gösteriniz

--select * from Products where UnitPrice>100

-- kategorisi 7 ve 8 olan ürünleri listeleyiniz.

--select * from Products where CategoryID=8 or CategoryID=7

--kategorisi 7 ve 8 olanlardan stok miktarý 10dan düþük olan ürünleri listeleyiniz

--select * from Products where (CategoryID=8 or CategoryID=7) and UnitsInStock<=10 

--kategorisi 7 ve 8 olanlardan stok miktarý 10dan düþük olan ürünlerin sayýsý
--select count(*) from Products where (CategoryID=8 or CategoryID=7) and UnitsInStock<=10

-----INNER JOIN-----
--select Products.ProductName,Categories.CategoryName from Products inner join Categories
--	on Products.CategoryID=Categories.CategoryID

-- kýsaltma hali harf tanýmlýyoruz.
--select P.ProductName,C.CategoryName 
--from Products P inner join Categories C
--on P.CategoryID=C.CategoryID

--select P.ProductName,C.CategoryName, P.UnitPrice
--from Products P inner join Categories C
--on P.CategoryID=C.CategoryID
--where CategoryName='Beverages' and P.UnitPrice<=40
--order by P.UnitPrice desc

---Product Name ve Supplier Company Name gösteren bir sorgu yazýnýz.

--select P.ProductName,S.CompanyName
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID

--Germany den tedarik edilen ürünlerin Product name listesi

--select P.ProductName,S.Country
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID
--where Country='Germany'

----Germany den tedarik edilen ürünlerin toplam tutarý

--select sum(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar' 
--from Products P inner join Suppliers S
--on P.SupplierID=S.SupplierID
--where Country='Sweden'

-------Chai satýþlarýnýn toplam tutarý
--select sum(OD.UnitPrice * OD.Quantity) as 'Toplam Tutar' 
--from Products P inner join [Order Details] OD
--on P.ProductID=OD.ProductID
--where p.ProductName='Chai'


-----Germanye yapýlmýþ Chai satýþlarýnýn toplam tutarý
--select sum(OD.UnitPrice * Od.Quantity) as 'Toplam Tutar' 
--from Orders O inner join [Order Details] OD
--on O.OrderID=OD.OrderID inner join Products P
--on OD.ProductID = P.ProductID
--where O.ShipCountry='Germany' and P.ProductName='Chai'


--- Ernst Handel müþterisine yapýlan satýþ tutarýnýn toplamý
select sum(OD.UnitPrice * OD.Quantity)
from [Order Details] OD inner join Orders O
on OD.OrderID = O.OrderID inner join Customers C
on O.CustomerID=C.CustomerID
where c.CompanyName='Ernst Handel'
