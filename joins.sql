select SP.NAME, SP.STATEPROVINCECODE, SP.COUNTRYREGIONCODE from person.StateProvince SP join Person.CountryRegion CR 
ON SP.CountryRegionCode = CR.CountryRegionCode
WHERE SP.NAME = 'British Columbia'

--INNER JOIN
SELECT  TOP 50 P.ProductID, 
 P.Name, P.ListPrice, P.Size,P.SizeUnitMeasureCode,P.WeightUnitMeasureCode,SOD.UnitPrice, SOD.UnitPriceDiscount,SOD.OrderQty,SOD.LineTotal 
FROM Sales.SalesOrderDetail SOD 
INNER JOIN Production.Product P ON SOD.ProductID = P.ProductID 
WHERE SOD.UnitPrice > 1000 ORDER BY SOD.UnitPrice DESC

