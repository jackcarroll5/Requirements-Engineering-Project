-- MusicStoreSYS.sql
--This script builds the database for a music store system

PROMPT Dropping All Tables
PROMPT

DROP TABLE CDs;
DROP TABLE OrderItems;
DROP TABLE Payments;
DROP TABLE Suppliers;
DROP TABLE Orders;

PROMPT
PROMPT Creating tables
PROMPT

CREATE TABLE Suppliers
(Supp_Id numeric(3)NOT NULL,
Supp_Name char(20) NOT NULL,
PhoneNo numeric (15),
Email char (30),
Street char (25) NOT NULL,
TownVillage char (20) NOT NULL,
County char (20) NOT NULL,
Acc_Bal numeric (5,2),
Status char (1),
CONSTRAINT pk_Suppliers PRIMARY KEY (Supp_Id));

CREATE TABLE CDs
(CD_ID numeric(5) NOT NULL,
Album_Name char (30) NOT NULL,
Artist char (30) NOT NULL,
Year_Released numeric (4),
Artist_Label char (15) NOT NULL,
Cost_Price numeric (5,2) NOT NULL,
Qty numeric (3),
Availability char (1),
CONSTRAINT pk_CDs PRIMARY KEY (CD_ID));


CREATE TABLE Orders
(OrderID numeric (4) NOT NULL,
  OrdDate Date NOT NULL,
  OrdValue numeric (5,2),
  Status char (1),
  Supp_Id numeric(3)NOT NULL,
 CONSTRAINT pk_Orders PRIMARY KEY (OrderID),
 CONSTRAINT fk_Orders_Suppliers FOREIGN KEY (Supp_Id) REFERENCES Suppliers);
   
 CREATE TABLE OrderItems
 (OrdID numeric(5) NOT NULL,
     Qty numeric (5),
    Unit_Cost numeric (5,2),
    OrderID numeric (4) NOT NULL,
    CD_ID numeric(5) NOT NULL,
    CONSTRAINT pk_OrderItems PRIMARY KEY (OrdID),
  CONSTRAINT fk_OrderItems_Orders FOREIGN KEY (OrderID) REFERENCES Orders,
   CONSTRAINT fk_OrderItems_CDs FOREIGN KEY (CD_ID) REFERENCES CDs);
   
   CREATE TABLE Payments
   (PaymentID numeric (6) NOT NULL,
   Amount numeric (5,2),
   PaymentDate Date,
   Supp_Id numeric(3)NOT NULL,
   CD_ID numeric(5) NOT NULL,
  CONSTRAINT pk_Payments PRIMARY KEY (PaymentID),
  CONSTRAINT fk_Payments_Suppliers FOREIGN KEY (Supp_Id) REFERENCES Suppliers,
  CONSTRAINT fk_Payments_CDs FOREIGN KEY (CD_ID) REFERENCES CDs); 