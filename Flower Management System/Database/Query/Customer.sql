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

-- show database query
select * from Customer order by ID asc

-- add query
insert into Customer values ('C-00001', N'A', '15/02/1997', 'Male', '01266143265', 'Vietnam')
insert into Customer values ('C-00002', N'B', '01/08/1997', 'Male', '', 'Vietnam')
insert into Customer values ('C-00003', N'C', '',' Male', '', 'Vietnam')
insert into Customer values ('C-00004', N'D', '', 'Male', '01653946836', 'Vietnam')
insert into Customer values ('C-00005', N'E', '06/09/1997', 'Female', '0935149090', 'Vietnam')
insert into Customer values ('C-00006', N'F', '28/05/1997', 'Female', '', 'Vietnam')
insert into Customer values ('C-00007', N'G', '28/07/1997', 'Male', '0918785353', 'Vietnam')
insert into Customer values ('C-00008', N'H', '19/10/1997', 'Female', '01268931128', 'Vietnam')
insert into Customer values ('C-00009', N'I', '23/09/1996', 'Female', '01655171569', 'Vietnam')
insert into Customer values ('C-00010', N'J', '15/07/1997', 'Male', '01265565596', 'Vietnam')
insert into Customer values ('C-00011', N'L', '19/07/1997', 'Male', '0904817934', 'Vietnam')
insert into Customer values ('C-00012', N'M', '04/09/1997', 'Male', '01286154090', 'Vietnam')
insert into Customer values ('C-00013', N'M', '16/10/1998', 'Female', '01256385142', 'Vietnam')
insert into Customer values ('C-00014', N'N', '09/11/1997', 'Female', '5157711171', 'Vietnam')

insert into Customer values ('', N'', '', '', '', '', '', )

-- update query
update Customer set FullName = N'Lê Tất Thịnh' where ID = 'E-00001'

-- delete query
delete from Customer where ID = 'E-00011'

-- search query
select * from Customer where FullName collate Latin1_General_CS_AS like N'%Thịnh%'