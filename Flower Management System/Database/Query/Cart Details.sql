create table CartDetail
(
	Cart_ID				nvarchar(10) not NULL,
	Flower_ID			nvarchar(10) not NULL,
	Quantity			int,
	Price				float,
	foreign key (Cart_ID) references Cart (ID),
	foreign key (Flower_ID) references Flower (ID)
)

-- drop table CartDetail

-- show database query
select Cart_ID, Flower_ID, Flower.FullName, Quantity, CartDetail.Price from CartDetail, Flower, Cart where CartDetail.Cart_ID = Cart.ID and CartDetail.Flower_ID = Flower.ID order by Cart_ID asc

-- add query
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00001', 'F-00001', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00001', 'F-00002', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00001', 'F-00003', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00001', 'F-00004', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00001', 'F-00005', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00001', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00002', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00003', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00004', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00005', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00002', 'F-00006', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00003', 'F-00007', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00003', 'F-00008', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00004', 'F-00009', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00004', 'F-00010', 4)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00005', 'F-00011', 2)
insert into CartDetail (Cart_ID, Flower_ID, Quantity) values ('SC-00005', 'F-00005', 1)

delete from CartDetail where Cart_ID = 'CT-1'

-- search
select Cart_ID, Flower_ID, Flower.FullName, Quantity, CartDetail.Price, Flower.Picture 
from CartDetail, Flower, Cart 
where CartDetail.Cart_ID = Cart.ID
and Cart.ID = 'SC-00003'
and CartDetail.Flower_ID = Flower.ID

update CartDetail 
set Price = (Quantity * (select Price from Flower where CartDetail.Flower_ID = Flower.ID))