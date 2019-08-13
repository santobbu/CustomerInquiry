CREATE DATABASE CustomerInquiry;

CREATE TABLE Customers (
    CustomerId int NOT NULL PRIMARY KEY,
    CustomerName varchar(255),
    Email varchar(255),
    MobileNo varchar(255),
);