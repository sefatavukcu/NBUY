--select distinct CategoryID from Products
-- tekrar eden verilerde tekrarlar� g�stermez 

--- Bu g�ne kadar hangi �lkelere kargo g�nderilmi�
--select distinct ShipCountry from Orders
--order by ShipCountry

--- Hangi �lkeye ne kadar sat�� yap�lm��
--select O.ShipCountry, sum(OD.Quantity * OD.UnitPrice) as 'Toplam Tutar'
--from Orders O inner join [Order Details] OD
--on O.OrderID = OD.OrderID
--group by O.ShipCountry
--order by 'Toplam Tutar' desc

----- En �ok sat�� yap�lan 3 �lke
--select top(3) O.ShipCountry, sum(OD.Quantity * OD.UnitPrice) as 'Toplam Tutar'
--from Orders O inner join [Order Details] OD
--on O.OrderID = OD.OrderID
--group by O.ShipCountry
--order by 'Toplam Tutar' desc

--- Elimizde en �ok sto�u bulunan ilk 3 �r�n
--select top(3) Products.ProductName, Products.UnitsInStock
--from Products
--order by Products.UnitsInStock desc

--- hangi kategoride ka� adet �r�n var
--select C.CategoryName, count(*) as 'Adet'
--from Products P inner join Categories C
--on C.CategoryID = P.CategoryID
--group by C.CategoryName
--having count(*)>10     -- gruplanm�� olan dataya filtre uyguland�. Adeti 10'dan b�y�k olan �r�nleri listeledik
--order by 'Adet' desc

---6) Hangi �r�nden ka� tane sat�lm��t�r
--select P.ProductName, count(*) as 'Adet'
--from Products P inner join [Order Details] OD
--on P.ProductID = OD.ProductID
--group by P.ProductName 
--order by 'Adet' desc


---7) En �ok kazand�ran ilk 3 �r�n hangisidir
--select top(3) P.ProductName, sum(OD.Quantity * OD.UnitPrice) as 'Tutar'
--from Products P inner join [Order Details] OD
--on P.ProductID = OD.ProductID
--group by P.ProductName
--order by 'Tutar' desc

---8) Hangi kargo �irketine ne kadar �deme yap�lm��t�r. / Freight
--select S.CompanyName, sum(O.Freight) as 'Toplam Tutar'
--from Shippers S inner join  Orders O
--on S.ShipperID = O.ShipVia
--group by S.CompanyName

---9) En az �deme yap�lm�� kargo �irketi
--select top(1) S.CompanyName, sum(O.Freight) as 'Toplam Tutar'
--from Shippers S inner join  Orders O
--on S.ShipperID = O.ShipVia
--group by S.CompanyName
--order by 'Toplam Tutar' 

---10) Hangi b�lgede hangi �r�nden ka� paral�k sat�� yap�lm��t�r.
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

-----11) Hangi b�lgede hangi �r�nden ka�adet sat�� yap�lm��t�r.
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
