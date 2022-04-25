CREATE DATABASE MYBUS;

USE MYBUS;

CREATE TABLE BusInfo
(
Bus_ID INTEGER NOT NULL PRIMARY KEY,
BoardingPoint VARCHAR(30) NOT NULL,
TravelDate DATETIME NOT NULL,
Amount DECIMAL NOT NULL,
Rating INTEGER
);

INSERT INTO BusInfo(Bus_ID,BoardingPoint,TravelDate,Amount,Rating)
VALUES(1,'BGL',18-06-2017,400.65,2),
(2,'HYD',05-10-2017,600.00,3),
(3,'CHN',25-07-2016,445.95,3),
(4,'PUN',10-12-2017,543.00,4),
(5,'MUM',28-01-2017,500.50,4),
(6,'PUN',27-03-2016,333.55,3),
(7,'MUM',06-11-2016,510.00,4);

--Creating a Stored Procedure
CREATE PROCEDURE spMyBusInfo
AS
BEGIN
SELECT * FROM BusInfo
END

--To execute a Stored procedure
EXECUTE spMyBusInfo;

--a) Retrieve all BoardingPoint and TravelDate for the amount which is greater than 450.
SELECT BoardingPoint,TravelDate
FROM BusInfo
WHERE Amount > 450;

--b)Create View Bus_View to display the BusID, BoardingPoint whose rating is greater than 3
CREATE VIEW Bus_View
AS 
SELECT Bus_ID,BoardingPoint
FROM BusInfo
WHERE Rating>3;

SELECT * FROM Bus_View; --To execute a View






