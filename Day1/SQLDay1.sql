
--select a database
use master

--create a database
create database dbSample17Jan2022

--select the database
use dbSample17Jan2022

--create table
Create table tblLocation
(locationName varchar(20) primary key,
zipcode varchar(5))

sp_Help tblLocation

alter table tblLocation
add anotherColumn int

alter table tblLocation
drop column anotherColumn

drop table tblLocation

create table tblEmployee
(EmployeeID	int identity(101,1) primary key,
Name varchar(20) not null,
Phone varchar(15),	
Location varchar(20)  references tblLocation(locationName),
Age	int,
Email varchar(100),
JoiningDate	DateTime,
Role varchar(15) check(role in ('Manager','Developer','Sr.Developer','Tester')))

sp_help tblEmployee

create table tblSkill
(skillName varchar(20) constraint pk_skill primary key,
skill_description varchar(100))

create table tblEmployeeSkill
(EmpID int constraint fk_empSkill foreign key references tblEmployee(EmployeeId),
Skill varchar(20) references tblSkill(skillName),
Skill_Level float,
primary key(EmpID,Skill))

sp_help tblEmployeeSkill

insert into tblLocation values('xyz','123')
insert into tblLocation(zipcode,locationName) values('333',	'zzz')

select * from tblLocation
insert into tblEmployee(name,Location,Age,Role,Phone,Email) 
values('ABC','xyz',31,'Manager','1234567890','abc@gmail.com')

insert into tblEmployee(name,Location,Age,Role,Phone,Email) 
values('ABC','zzz',31,'Developer','dgsdfgdfhdfgggfhdfghfg','abc@gmail.com')

select * from tblEmployee

insert into tblSkill values('C','PLT')
insert into tblSkill values('C++','OOPS')
insert into tblSkill values('Java','Web')
insert into tblSkill values('.NET','Web')
insert into tblSkill values('SQL','RDBMS')

select * from tblSkill

insert into tblEmployeeSkill values(101,'C',9)
insert into tblEmployeeSkill values(101,'C++',8)
insert into tblEmployeeSkill values(101,'Java',7)

select * from tblEmployeeSkill

update tblEmployeeSkill set Skill_Level = 8 where EmpID=101 and Skill='Java'

delete from tblEmployeeSkill where EmpID=101 and Skill='Java'