USE TechShop;
SELECT * FROM Customers;
select * from Products;
select * from Orders;
select * from OrderDetails;

1. Write an SQL query to retrieve the names and emails of all customers. consider previous data 

SELECT FirstName,LastName,Email from Customers;


2. Write an SQL query to list all orders with their order dates and corresponding customer names

SELECT Orders.OrderID, Customers.FirstName, Customers.LastName, Orders.OrderDate FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;


3. Write an SQL query to insert a new customer record into the "Customers" table. Include customer information such as name, email, and address.

INSERT INTO Customers VALUES ('11', 'Tanaya','Dhuri', 'tanayadhuri@example.com', '143456572', '123 pune');



4. Write an SQL query to update the prices of all electronic gadgets in the "Products" table by increasing them by 10%. 

UPDATE Products
SET Price = Price * 1.1;

5. Write an SQL query to delete a specific order and its associated order details from the "Orders" and "OrderDetails" tables. Allow users to input the order ID as a parameter

DELETE FROM OrderDetails
WHERE OrderID = 100;

DELETE FROM Orders
WHERE OrderID = 100;


6. Write an SQL query to insert a new order into the "Orders" table. Include the customer ID, order date, and any other necessary information.

INSERT INTO Orders VALUES (100,10,'2024-09-24', 1999.00);


7. Write an SQL query to update the contact information (e.g., email and address) of a specific customer in the "Customers" table. Allow users to input the customer ID and new contact information.

UPDATE Customers
SET Email = 'parabakshay@example.com', 
    Address ='1234 vetore'
WHERE CustomerID = 1;


8. Write an SQL query to recalculate and update the total cost of each order in the "Orders" table based on the prices and quantities in the "OrderDetails" table.

UPDATE Orders
SET TotalAmount = (
    SELECT SUM( price* Quantity)
    FROM OrderDetails
    WHERE OrderDetails.OrderID = Orders.OrderID
);


9. Write an SQL query to delete all orders and their associated order details for a specific customer from the "Orders" and "OrderDetails" tables. Allow users to input the customer ID as a parameter.

DELETE FROM OrderDetails
WHERE OrderID IN (
    SELECT OrderID 
    FROM Orders 
    WHERE CustomerID = 1
);

DELETE FROM Orders
WHERE CustomerID = 1;


10. Write an SQL query to insert a new electronic gadget product into the "Products" table, including product name, category, price, and any other relevant details.

INSERT INTO Products VALUES ('21','Smartphone X12','Latest smartphone with 6.5-inch display and 128GB storage','12999.00');


11. Write an SQL query to update the status of a specific order in the "Orders" table (e.g., from "Pending" to "Shipped"). Allow users to input the order ID and the new status.

UPDATE Orders
SET Status = 'Shipped'
WHERE OrderID = 11;


12. Write an SQL query to calculate and update the number of orders placed by each customer in the "Customers" table based on the data in the "Orders" table.

UPDATE Customers
SET NumberOfOrders = TotalOrders
FROM (
    SELECT CustomerID, COUNT(*) AS TotalOrders
    FROM Orders
    GROUP BY CustomerID
) AS OrderCounts
WHERE Customers.CustomerID = OrderCounts.CustomerID;
