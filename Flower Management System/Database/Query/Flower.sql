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
-- show database query
select * from Flower order by ID asc

-- add query
--image
insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00001', N'Romance', 49.99, 'Anniversary', 'Europe', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Romance.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00002', N'Two Dozen Red Roses', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Two Dozen Red Roses.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00003', N'Expressions of Pink', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Expressions of Pink.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00004', N'Red Roses', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Red Roses.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00005', N'Floral Treasures Bouquet', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Floral Treasures Bouquet.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00006', N'Magnificent Pink Rose and Lily', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Magnificent Pink Rose and Lily.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00007', N'Ocean Breeze Orchids', 51.11, 'Anniversary', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Anniversary\Ocean Breeze Orchids.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00008', N'Happy Birthday', 51.11, 'Birthday', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Birthday\Happy Birthday.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00009', N'Floral Treasures Bouquet', 51.11, 'Birthday', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Birthday\Floral Treasures Bouquet.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00010', N'For Spring', 51.11, 'Birthday', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Birthday\For Spring.jpg', single_blob) as FlowerImage

insert into Flower (ID, FullName, Price, UseFor, Country, Picture) 
select 'F-00011', N'Country Charm', 51.11, 'Birthday', '', BulkColumn 
from Openrowset(Bulk 'D:\SchoolAssignment\PTTK\Flower Management System\Images\Flower Management\Flower\Birthday\Country Charm.jpg', single_blob) as FlowerImage

-- update query
update Flower set FullName = N'Red Rosesh' where ID = 'F-00004'

-- delete query
delete from Flower where ID = 'F-00004'

-- search query
select * from Flower where FullName collate Latin1_General_CS_AS like N'%Thịnh%'