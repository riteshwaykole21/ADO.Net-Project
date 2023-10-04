Create Database EMPLOYEEDB
Create Table Employee
( 
   E_ID Numeric Identity(1,1),
   E_Name Varchar(255),
   E_CITY varchar(255),
   E_Contact varchar(255)
)
insert into Employee
Values
('Sujay','Hydrarbad','7775905919'),
('Ritesh','Talwel','9834032628'),
('Hitesh','Bangluru','1234567891')
Select * From Employee