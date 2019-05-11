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

-- show database query
select * from Employee order by ID asc

-- add query
insert into Employee values ('E-00001', N'Lê Tất Thịnh', '15/02/1997', 'Male', '01266143265', 'Vietnam','Boss', 1200)
insert into Employee values ('E-00002', N'Phan Huy Cường', '01/08/1997', 'Male', '', 'Vietnam', 'Manager', 900)
insert into Employee values ('E-00003', N'Nguyễn Minh Nghị', '',' Male', '', 'Vietnam', 'Boss', 850)
insert into Employee values ('E-00004', N'Đinh Quang Vinh', '', 'Male', '01653946836', 'Vietnam', '', 500)
insert into Employee values ('E-00005', N'Ngô Thùy Tiên', '06/09/1997', 'Female', '0935149090', 'Vietnam', '', 550)
insert into Employee values ('E-00006', N'Trương Thị Thu Thảo', '28/05/1997', 'Female', '', 'Vietnam', '', 400)
insert into Employee values ('E-00007', N'Trần Thành Nhân', '28/07/1997', 'Male', '0918785353', 'Vietnam', '', 630)
insert into Employee values ('E-00008', N'Nguyễn Thị Bích Hiền', '19/10/1997', 'Female', '01268931128', 'Vietnam', '', 500)
insert into Employee values ('E-00009', N'Hà Thị Thảo', '23/09/1996', 'Female', '01655171569', 'Vietnam', '', 500)
insert into Employee values ('E-00010', N'Trần Hoàng Đức', '15/07/1997', 'Male', '01265565596', 'Vietnam', '', 500)
insert into Employee values ('E-00010', N'Trần Hoàng Đức', '15/07/1997', 'Male', '01265565596', 'Vietnam', '', 500)
insert into Employee values ('E-00011', N'Nguyễn Hoàng Anh', '19/07/1997', 'Male', '0904817934', 'Vietnam', '', 500)
insert into Employee values ('E-00012', N'Nguyễn Trần Trọng Nhân', '04/09/1997', 'Male', '01286154090', 'Vietnam', '', 500)
insert into Employee values ('E-00013', N'Nguyễn Xuân Phú', '16/10/1998', 'Female', '01256385142', 'Vietnam', '', 500)
insert into Employee values ('E-00014', N'Giang Minh Nguyệt', '09/11/1997', 'Female', '5157711171', 'Vietnam', '', 500)

insert into Employee values ('', N'', '', '', '', '', '', )
Nguyễn Thị Bích Hiền
-- update query
update Employee set FullName = N'Lê Tất Thịnh' where ID = 'E-00001'

-- delete query
delete from Employee where ID = 'E-00011'

-- search query
select * from Employee where FullName collate Latin1_General_CS_AS like N'%Thịnh%'