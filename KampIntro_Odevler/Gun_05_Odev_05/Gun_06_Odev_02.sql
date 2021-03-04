SELECT p.ProductName [Ürün Adı], SUM(Details.Quantity*Details.UnitPrice) [Kazanılan Toplam Tutar]
FROM Products p
INNER JOIN [Order Details] Details ON p.ProductID = Details.ProductID 
INNER JOIN Orders o ON o.OrderID = Details.OrderID
GROUP BY ProductName 
ORDER BY ProductName ASC