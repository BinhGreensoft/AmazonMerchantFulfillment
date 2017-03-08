-- Settings
Create table Para (
	PK			bigint identity not null,
	ParaId		nvarchar(30) not null,
	ParaName	nvarchar(200) not null,
	ParaValue	nvarchar(200),
	constraint Para_PK primary key (PK),
	constraint Para_ParaId_UK unique (ParaId))
go

insert into Para (ParaId, ParaName, ParaValue) values ('01', 'Shipping cost threshold', '1');
insert into Para (ParaId, ParaName, ParaValue) values ('02', 'Shipping label length (inches)', '20');
insert into Para (ParaId, ParaName, ParaValue) values ('03', 'Shipping label width (inches)', '10');
