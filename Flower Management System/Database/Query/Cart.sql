create table Cart
(
	ID					nvarchar(10) not NULL,
	Customer_ID			nvarchar(10) not NULL,
	OnDate				nvarchar(10),
	TotalPrice				float,
	primary key (ID),
	foreign key (Customer_ID) references Customer (ID)
)

-- show database query
select Cart.ID, Customer_ID, Customer.FullName, OnDate, TotalPrice from Cart, Customer where Customer_ID = Customer.ID order by Cart.ID asc

-- add query
insert into Cart (ID, Customer_ID, OnDate) values ('SC-00001', 'C-00001', '15/02/2017')
insert into Cart (ID, Customer_ID, OnDate) values ('SC-00002', 'C-00001', '15/02/2017')
insert into Cart (ID, Customer_ID, OnDate) values ('SC-00003', 'C-00001', '15/02/2017')
insert into Cart (ID, Customer_ID, OnDate) values ('SC-00004', 'C-00001', '15/02/2017')
insert into Cart (ID, Customer_ID, OnDate) values ('SC-00005', 'C-00001', '15/02/2017')

delete from Cart where ID = 'SC-00005'

update Cart 
set TotalPrice = (select sum(Price) from CartDetail where CartDetail.Cart_ID = Cart.ID)

select ID from Cart where ID = 'SC-00001'