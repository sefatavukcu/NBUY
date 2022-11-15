
--select *
--from Customers C inner join Orders O
--on C.CustomerID = O.CustomerID 
-------inner join eþleþenleri getirir ikisndede
------- left join sol taraftaki tablonun hepsini getirip saðdaki tabloyla eþleþenleri getirir.
--select *
--from Customers C left join Orders O
--on C.CustomerID = O.CustomerID 
--where O.OrderID is null

------ right join de saðdaki tablonun hepsini getirip saðdaki tabloyla eþleþenleri getirir.
--select *
--from Orders O right join Customers C 
--on C.CustomerID = O.CustomerID 
--where O.OrderID is null

----Henüz satýlmamýþ ürünler
--select P.ProductName, OD.ProductID
--from [Order Details] OD right join Products P
--on OD.ProductID = P.ProductID 
--where OD.ProductID is not null

----Henüz satýþ yapamamýþ çalýþanlarý listele
select *
from Employees E left join Orders O
on E.EmployeeID=O.EmployeeID
where O.EmployeeID is null