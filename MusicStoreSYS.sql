-- MusicStoreSYS.sql
--This script builds the database for a music store system

PROMPT Dropping All Tables
PROMPT
DROP TABLE Payments;
DROP TABLE OrderItems;
DROP TABLE CDs;
DROP TABLE Orders;
DROP TABLE Suppliers;
DROP TABLE Counties;


PROMPT
PROMPT Creating tables
PROMPT

CREATE TABLE Counties
(County_Code char(2),
Name char(15),
CONSTRAINT pk_Counties PRIMARY KEY (County_Code));

INSERT INTO Counties
VALUES('AH','Armagh');
INSERT INTO Counties
VALUES('CK','Cork');
INSERT INTO Counties
VALUES('DW','Down');
INSERT INTO Counties
VALUES('DN','Dublin');
INSERT INTO Counties
VALUES('LK','Limerick');
INSERT INTO Counties
VALUES('KY','Kerry');
INSERT INTO Counties
VALUES('TI','Tipperary');
INSERT INTO Counties
VALUES('WA','Waterford');
INSERT INTO Counties
VALUES('WX','Wexford');


CREATE TABLE Suppliers
(Supp_Id numeric(3)NOT NULL,
Supp_Name char(20) NOT NULL,
PhoneNo numeric (15),
Email char (30),
Street char (25) NOT NULL,
TownVillage char (20) NOT NULL,
County_Code char (2) NOT NULL,
Acc_Bal numeric (5,2),
Status char (1),
CONSTRAINT pk_Suppliers PRIMARY KEY (Supp_Id),
CONSTRAINT fk_Supp_Counties FOREIGN KEY (County_Code) REFERENCES Counties);

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
  
  COMMIT;