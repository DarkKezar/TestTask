-- Создание таблицы Продуктов
CREATE TABLE Products (
  ProductID INT PRIMARY KEY IDENTITY(1,1),  
  ProductName NVARCHAR(255) NOT NULL 
);

-- Создание таблицы Категорий продуктов
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1), 
    CategoryName NVARCHAR(255) NOT NULL    
);

-- Реализация связи многие-ко-многим
CREATE TABLE ProductCategories (
   ProductID INT NOT NULL,
   CategoryID INT NOT NULL,
    
   PRIMARY KEY (ProductID, CategoryID),     
   FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE,
   FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE CASCADE 
);

-- Запрос из задания
SELECT
    p.ProductName AS ProductName,
    c.CategoryName AS CategoryName
FROM
    Products p
        LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
        LEFT JOIN
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY
    p.ProductName, c.CategoryName;