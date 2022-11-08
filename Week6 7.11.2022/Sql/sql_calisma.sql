--select distinct CategoryID from Products
-- tekrar eden verilerde tekrarlarý göstermez 

--- Bu güne kadar hangi ülkelere kargo gönderilmiþ
--select distinct ShipCountry from Orders
--order by ShipCountry

--- Hangi ülkeye ne kadar satýþ yapýlmýþ
--select O.ShipCountry, sum(OD.Quantity * OD.UnitPrice) as 'Toplam Tutar'
--from Orders O inner join [Order Details] OD
--on O.OrderID = OD.OrderID
--group by O.ShipCountry
--order by 'Toplam Tutar' desc

----- En çok satýþ yapýlan 3 ülke
--select top(3) O.ShipCountry, sum(OD.Quantity * OD.UnitPrice) as 'Toplam Tutar'
--from Orders O inner join [Order Details] OD
--on O.OrderID = OD.OrderID
--group by O.ShipCountry
--order by 'Toplam Tutar' desc

--- Elimizde en çok stoðu bulunan ilk 3 ürün
--select top(3) Products.ProductName, Products.UnitsInStock
--from Products
--order by Products.UnitsInStock desc

--- hangi kategoride kaç adet ürün var
--select C.CategoryName, count(*) as 'Adet'
--from Products P inner join Categories C
--on C.CategoryID = P.CategoryID
--group by C.CategoryName
--having count(*)>10     -- gruplanmýþ olan dataya filtre uygulandý. Adeti 10'dan büyük olan ürünleri listeledik
--order by 'Adet' desc

---6) Hangi üründen kaç tane satýlmýþtýr
--select P.ProductName, count(*) as 'Adet'
--from Products P inner join [Order Details] OD
--on P.ProductID = OD.ProductID
--group by P.ProductName 
--order by 'Adet' desc


---7) En çok kazandýran ilk 3 ürün hangisidir
--select top(3) P.ProductName, sum(OD.Quantity * OD.UnitPrice) as 'Tutar'
--from Products P inner join [Order Details] OD
--on P.ProductID = OD.ProductID
--group by P.ProductName
--order by 'Tutar' desc

---8) Hangi kargo þirketine ne kadar ödeme yapýlmýþtýr. / Freight
--select S.CompanyName, sum(O.Freight) as 'Toplam Tutar'
--from Shippers S inner join  Orders O
--on S.ShipperID = O.ShipVia
--group by S.CompanyName

---9) En az ödeme yapýlmýþ kargo þirketi
--select top(1) S.CompanyName, sum(O.Freight) as 'Toplam Tutar'
--from Shippers S inner join  Orders O
--on S.ShipperID = O.ShipVia
--group by S.CompanyName
--order by 'Toplam Tutar' 

---10) Hangi bölgede hangi üründen kaç paralýk satýþ yapýlmýþtýr.
--select R.RegionDescription,P.ProductName, sum(OD.Quantity * OD.UnitPrice) as 'Total Price'
--from Region R inner join Territories T
--	on R.RegionID = T.RegionID inner join EmployeeTerritories ET
--	on T.TerritoryID = ET.TerritoryID inner join  Employees E
--	on ET.EmployeeID = E.EmployeeID inner join Orders O
--	on E.EmployeeID = O.EmployeeID inner join [Order Details] OD
--	on O.OrderID = OD.OrderID inner join Products P
--	on OD.ProductID = P.ProductID
--	group by R.RegionDescription,P.ProductName
--	order by R.RegionDescription, P.ProductName, 'Total Price'

-----11) Hangi bölgede hangi üründen kaçadet satýþ yapýlmýþtýr.
--select R.RegionDescription,P.ProductName, count(*) as 'Total'
--from Region R inner join Territories T
--	on R.RegionID = T.RegionID inner join EmployeeTerritories ET
--	on T.TerritoryID = ET.TerritoryID inner join  Employees E
--	on ET.EmployeeID = E.EmployeeID inner join Orders O
--	on E.EmployeeID = O.EmployeeID inner join [Order Details] OD
--	on O.OrderID = OD.OrderID inner join Products P
--	on OD.ProductID = P.ProductID
--	group by R.RegionDescription,P.ProductName
--	order by R.RegionDescription, P.ProductName, 'Total'
