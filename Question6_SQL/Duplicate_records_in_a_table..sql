--6. Write a SQL query to find duplicate records in a table.

CREATE DATABASE OfficeDB;

USE OfficeDB;

CREATE TABLE Staff (
    Id INT,
    Name VARCHAR(50),
    Salary INT
);

INSERT INTO Staff (Id, Name, Salary) VALUES
(1, 'Amit', 40000),
(2, 'Sneha', 60000),
(3, 'Rahul', 75000),
(4, 'Priya', 52000),
(5, 'Rohan', 48000),
(6, 'Neha', 67000),
(7, 'Karan', 30000),
(8, 'Pooja', 55000),
(9, 'Vikas', 72000),
(10, 'Anjali', 51000),
(11, 'Amit', 40000),
(12, 'Sneha', 60000),
(13, 'Rahul', 75000),
(14, 'Priya', 52000),
(15, 'Rohan', 48000),
(16, 'Meena', 80000),
(17, 'Ajay', 47000),
(18, 'Deepak', 62000),
(19, 'Amit', 40000),
(20, 'Neha', 67000);

SELECT * FROM Staff
    
-- SQL query to find duplicate records in a table.
    
WITH CTE AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Name ORDER BY Id) AS rn
    FROM Staff
)
SELECT *
FROM CTE
WHERE rn > 1;


