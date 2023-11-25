
Create Database RoyexTechnologies;

use RoyexTechnologies;


Create Table Manager (
	Id int primary key identity(1,1),
	Name varchar(20) not null, 
	Position varchar(20) not null,
	Salary int not null,
	JoiningDtate datetime not null
);

Create Table GeneralManager(
	Id int primary key identity(1,1), 
	Name varchar(20) not null,
	Position varchar(20) not null,
	Salary int not null, 
	JoiningDtate datetime not null, ManagerId int
	foreign key references Manager(Id)
);

Create Table OfficeExecutive(
	Id int primary key identity(1,1), 
	Name varchar(20) not null,
	Position varchar(20) not null,
	Salary int not null, 
	JoiningDtate datetime not null, GeneralManagerId int
	foreign key references GeneralManager(Id)
);

insert into Manager values('Sojib','Manager',500,'2000-09-25');

insert into GeneralManager values('Sopon','GeneralManager',200,'2018-09-25',1),
	('Sopon','GeneralManager',200,'2018-09-25',1),
	('Arif','GeneralManager',200,'2021-09-25',1),
	('Karim','GeneralManager',200,'2022-09-25',1);

insert into GeneralManager values('Sopon','GeneralManager',200,'2018-09-25',1),
	('Sopon','GeneralManager',200,'2018-09-25',1),
	('Arif','GeneralManager',200,'2021-09-25',1),
	('Karim','GeneralManager',200,'2022-09-25',1);


insert into OfficeExecutive values('Abrar','OfficeExecutive',100,'2017-09-25',2),
	('Nayeem','OfficeExecutive',100,'2019-09-25',3),
	('Saikot','OfficeExecutive',100,'2020-09-25',1),
	('Reja','OfficeExecutive',100,'2015-09-25',2);


drop table Manager;
drop table GeneralManager;
drop table OfficeExecutive;

ALTER TABLE Manager DROP CONSTRAINT FK_Constraint1;

