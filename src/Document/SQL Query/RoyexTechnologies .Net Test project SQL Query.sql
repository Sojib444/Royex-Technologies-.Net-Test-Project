

create database Royex;
use Royex;

Create table Employees (
	Id int primary key identity(1,1),
	Name varchar(30) not null,
	Position int not null,
	Salary int not null, 
	JoiningDate datetime not null, 
	IsbonusAdded bit not null
);

insert into Employees values
	('Sopon',1,500,'2018-09-25',1),
	('Sopon',1,200,'2018-09-25',0),
	('Arif',1,200,'2021-09-25',0),
	('Karim',1,200,'2022-09-25',0),
	('Sopon',2,200,'2018-09-25',0),
	('Arif',2,200,'2021-09-25',0),
	('Karim',2,200,'2022-09-25',0);