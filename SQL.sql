--Create Database WinformsDUCCompany1;
Use WinformsDUCCompany1
Go
create table Users
(-- the following line means Id is int ,not null, auto increment 
  UserId int not null identity(1,1),
  UserName varchar(50) not null,
  UserEmail varchar(50) not null,
  UserPassword varchar(500) not null,
  UserRole varchar(50) not null,
primary key (UserId),
);
Go
create table Departments
(-- the following line means DepartmentId is int ,not null, auto increment 
  DepartmentId int not null identity(1,1),
  DepartmentName varchar(50) not null,
  primary key (DepartmentId),
);
INSERT INTO Departments (DepartmentName) VALUES 
('Accounting'),
('Director'),
('IT')
;
Go
create table Positions
(-- the following line means PositionId is int ,not null, auto increment 
  PositionId int not null identity(1,1),
  PositionName varchar(50) not null,
  -- the following line means DepartmentId is int, not null, is the foreign key 
  -- refers to DepartmentId of Departments,deleting,updating Departments =>deleting,updating Positions
  DepartmentId int not null references Departments(DepartmentId) ON DELETE CASCADE ON UPDATE CASCADE,
  DailySalary float not null,
  primary key (PositionId),
);
Go
INSERT INTO Positions (PositionName,DepartmentId,DailySalary) VALUES 
('Cost Accountant',1,10),
('Financial Accountant',1,11),
('Tax Accountant',1,11.5),
('CEO',2,50),
('Secretary',2,11),
('Java Developer',3,20),
('C# .Net Developer',3,20),
('Tester',3,15)
;
Go
create table Employees
(-- the following line means EmpId is int ,not null, auto increment 
  EmpId int not null identity(1,1),
  EmpName varchar(50) not null,
  EmpDOB Date not null,
  EmpGender VARCHAR(50) not null,
  EmpImagePath VARCHAR(200),
  EmpAddress VARCHAR(250) not null,
  -- the following line means DepartmentId is int, not null, is the foreign key 
  -- refers to DepartmentId of Departments,
  DepartmentId int not null references Departments(DepartmentId) ,
  -- the following line means PositionId is int, not null, is the foreign key 
  -- refers to PositionId of Positions,deleting,updating Positions =>deleting,updating Employees
 PositionId int not null references Positions(PositionId) ON DELETE CASCADE ON UPDATE CASCADE,
  primary key (EmpId),
);
Go




