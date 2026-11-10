UPDATE dbo.Products 
SET ImagePath = N'~/images/products/coffee.jpg' 
WHERE Id = 4; 
SELECT @@ROWCOUNT AS UpdatedRows;

SELECT Id, Name, ImagePath FROM dbo.Products ORDER BY Id;