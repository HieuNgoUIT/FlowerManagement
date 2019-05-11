create table Employee
(
	ID					nvarchar(10) not NULL,
	FullName			nvarchar(35),
	Birthday			varchar(10),
	Gender				nvarchar(10),
	PhoneNumber			nvarchar(20),
	Nationality			nvarchar(50),
	Position			nvarchar(30),
	Salary				int,
	primary key (ID),
)

create table Account
(
	Employee_ID					nvarchar(10) not NULL,
	Username					nvarchar(45),
	Password					nvarchar(25),
	primary key (Username),
	foreign key (Employee_ID) references Employee (ID)
)

create table Customer
(
	ID					nvarchar(10) not NULL,
	FullName			nvarchar(35),
	Birthday			varchar(10),
	Gender				nvarchar(10),
	PhoneNumber			nvarchar(20),
	Nationality			nvarchar(50),
	primary key (ID),
)

create table Flower
(
	ID				nvarchar(10) not NULL,
	FullName		nvarchar(65),
	Price			float,
	UseFor			nvarchar(40),
	Country			nvarchar(50),
	Picture			varbinary(max),
	primary key (ID),
)

create table Cart
(
	ID					nvarchar(10) not NULL,
	Customer_ID			nvarchar(10) not NULL,
	OnDate				nvarchar(10),
	TotalPrice				float,
	primary key (ID),
	foreign key (Customer_ID) references Customer (ID)
)

create table CartDetail
(
	Cart_ID				nvarchar(10) not NULL unique,
	Flower_ID			nvarchar(10) not NULL,
	Quantity			int,
	Price				float,
	foreign key (Cart_ID) references Cart (ID),
	foreign key (Flower_ID) references Flower (ID)
)