create table Account
(
	Employee_ID					nvarchar(10) not NULL,
	Username					nvarchar(45),
	Password					nvarchar(25),
	primary key (Username),
	foreign key (Employee_ID) references Employee (ID)
)

-- add query
insert into Account values ('E-00001', N'A','1')

-- update query
update Account set Username = N'Boss' where Employee_ID = 'E-00001'

-- delete query
delete from Account where Employee_ID = 'E-00099'

-- search query
select * from Account where Username collate Latin1_General_CS_AS like N'%Thịnh%'

-- select query
select * from Account
select Username, Password from Account where Username = 'Boss'