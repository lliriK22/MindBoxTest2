CREATE TABLE Product (
	Id int PRIMARY KEY,
	Name varchar(255) NOT NULL
);

CREATE TABLE Category (
  Id int PRIMARY KEY,
  NAME varchar(255) NOT NULL
);

CREATE TABLE ProductCategory(
	Id int PRIMARY KEY,
	ProductId int NOT NULL,
	CategoryId int NOT NULL
);

ALTER TABLE ProductCategory  
ADD CONSTRAINT FK_ProductCategory_Product_ProductId 
FOREIGN KEY(ProductId) REFERENCES Product (Id);

ALTER TABLE ProductCategory
ADD CONSTRAINT FK_ProductCategory_Category_CategoryId 
FOREIGN KEY(CategoryId) REFERENCES Category (Id);

Select p.Name as ProductName, 
c.Name as CategoryName
FROM Product p
LEFT JOIN ProductCategory pc on pc.ProductId = p.Id
LEFT JOIN Category c on pc.CategoryId = c.Id
ORDER BY p.Name, c.Name
