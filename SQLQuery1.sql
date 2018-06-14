use [master]
create database [PRN292 Lab3]
go
use [PRN292 Lab3]

create table Register (
	MemberCode nvarchar(20) primary key,
	Name nvarchar(20),
	Sex nvarchar(10),
	Address nvarchar(200),
	Telephone varchar(20),
	Email varchar(100)
)