CREATE DATABASE TechShop;
USE TechShop;

CREATE TABLE Customers (
  CustomerID INT PRIMARY KEY,
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  Email VARCHAR(100) UNIQUE NOT NULL,   

  Phone VARCHAR(20),
  Address VARCHAR(255)
);

CREATE TABLE Products (
  ProductID INT PRIMARY KEY,
  ProductName VARCHAR(100) NOT NULL,
  Description TEXT,
  Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE Orders (
  OrderID INT PRIMARY KEY,
  CustomerID INT NOT NULL,
  OrderDate DATETIME NOT NULL,
  TotalAmount DECIMAL(10,2) NOT NULL,
  FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
  OrderDetailID INT PRIMARY KEY,
  OrderID INT NOT NULL,
  ProductID INT NOT NULL,
  Quantity INT NOT NULL,
  FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),   

  FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Inventory (
  InventoryID INT PRIMARY KEY ,
  ProductID INT NOT NULL,
  QuantityInStock INT NOT NULL,
  LastStockUpdate DATETIME NOT NULL,
  FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);


INSERT INTO Customers VALUES
  ('1','Akshay', 'Parab', 'akshayparab@example.com', '1234567890', '123 Pune'),
  ('2','Latika', 'Thakur', 'latikathakur@example.com', '0987654321', '456 Vengurla math'),
  ('3','Vitthal', 'Parab', 'vitthalparab@example.com', '2345678901', '789 kudal Bav'),
  ('4','Sakshi', 'Kadam', 'sakshikadam@example.com', '3456789012','1011 Chiplun Rtn'),
  ('5','Shruti', 'Chavan', 'shrutichavan@example.com', '4567890123', '1415 mumbai pawai'),
  ('6','Kaushik', 'patil', 'kauhikpatil@example.com', '5678901234', '1617 mumbai west'),
  ('7','sumitra', 'kulkarni', 'sumitrakulkarni@example.com', '6789012345' ,'1819 pune pimpri'),
  ('8','omkar', 'bane', 'omkarbane@example.com', '7890123456', '2021 pune akurdi'),
  ('9','Dinesh', 'Mestry', 'dineshmestry@example.com', '8901234567', '2223 gujrat gdn'),
  ('10','Amisha', 'you', 'amishayou@example.com', '9012345678', '2425 pune');

 INSERT INTO Products VALUES
  ('11','Laptop', 'High-performance laptop for work and gaming', 1299.99),
  ('12','Smartphone', 'Latest generation smartphone with advanced features', 799.99),
  ('13','Tablet', 'Portable tablet for work, entertainment, and browsing', 399.99),
  ('14','Smartwatch', 'Stylish smartwatch with fitness tracking and notifications', 249.99),
  ('15','Wireless Headphones', 'High-quality wireless headphones for music and calls', 199.99),
  ('16','Gaming Console', 'Powerful gaming console with stunning graphics', 499.99),
  ('17','Television', 'Large-screen television for an immersive viewing experience', 899.99),
  ('18','Refrigerator', 'Energy-efficient refrigerator with spacious storage', 699.99),
  ('19','Washing Machine', 'High-capacity washing machine for efficient laundry care', 449.99),
  ('20','Air Conditioner', 'Powerful air conditioner for cooling your home', 499.99);

 INSERT INTO Orders VALUES
  (11, 2,'2023-11-15', 1599.98),
  (22, 3,'2023-12-01', 999.98),
  (33, 5,'2023-12-10', 649.98),
  (44, 1,'2023-12-20', 1799.97),
  (55, 4,'2024-01-05', 1149.97),
  (66, 6,'2024-01-15', 849.98),
  (77, 7,'2024-02-01', 1399.97),
  (88, 9,'2024-02-10', 249.99),
  (99, 8,'2024-02-20', 199.99),
  (100, 10,'2024-03-01', 399.99);

  
  INSERT INTO OrderDetails VALUES
  (01,11, 11, 2),
  (02,22, 12, 1),
  (03,33, 13, 2),
  (04,44, 14, 1),
  (05,55, 15, 3),
  (06,66, 16, 2),
  (07,77, 17, 1),
  (08,88, 18, 1),
  (09,99, 19, 1),
  (111,100, 20, 1);

  INSERT INTO Inventory VALUES
  (123,11,50,'2024-09-12'),
  (234,12,50,'2024-09-15'),
  (345,13,50,'2024-09-20'),
  (456,14,50,'2024-09-02'),
  (567,15,50,'2024-09-08'),
  (678,16,50,'2024-09-27'),
  (789,17,50,'2024-09-30'),
  (897,18,50,'2024-09-11'),
  (987,19,50,'2024-09-24'),
  (876,20,50,'2024-09-03');

  SELECT * FROM Customers;
  SELECT * FROM Orders;
  SELECT * FROM OrderDetails;
  SELECT * FROM Products;
  SELECT * FROM Inventory;
  
  
