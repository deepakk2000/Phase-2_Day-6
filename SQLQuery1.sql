create database ProductInventoryDB
 use ProductInventoryDB
 create table Product(
 ProductId int primary key,
 ProductName nvarchar(20),
 Price float,
 Quantity int,
 MfDate Date,
 ExpDate Date
 )
 insert into Product values(1,'Toy1',2000,2,'10-01-2023','10-02-2023')