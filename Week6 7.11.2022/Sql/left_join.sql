
--select *
--from Customers C inner join Orders O
--on C.CustomerID = O.CustomerID 
-------inner join e�le�enleri getirir ikisndede
------- left join sol taraftaki tablonun hepsini getirip sa�daki tabloyla e�le�enleri getirir.
--select *
--from Customers C left join Orders O
--on C.CustomerID = O.CustomerID 
--where O.OrderID is null

------ right join de sa�daki tablonun hepsini getirip sa�daki tabloyla e�le�enleri getirir.
--select *
--from Orders O right join Customers C 
--on C.CustomerID = O.CustomerID 
--where O.OrderID is null

----Hen�z sat�lmam�� �r�nler
--select P.ProductName, OD.ProductID
--from [Order Details] OD right join Products P
--on OD.ProductID = P.ProductID 
--where OD.ProductID is not null

----Hen�z sat�� yapamam�� �al��anlar� listele
select *
from Employees E left join Orders O
on E.EmployeeID=O.EmployeeID
where O.EmployeeID is null