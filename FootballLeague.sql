create database Ado;

use Ado;
insert into FootballLeague(Match_Id,TeamName1,TeamName2,Status,WinningTeam,Points)
values 
('1002','Brazil','Portugal','Draw','','2'),
('1003','England','Japan','Win','England','4'),
('1004','USA','Russia','Win','Russia','4'),
('1005','Portugal','Italy','Draw','','2'),
('1006','Brazil','France','Win','Brazil','4'),
('1007','England','Russia','Win','Russia','4'),
('1008','Japan','USA','Draw','','2')
select * from FootballLeague;

create proc Sp_FootballLeague_insert
@Match_Id int,
@TeamName1 varchar(50),
@TeamName2 varchar(50),
@Status varchar(50),
@WinningTeam varchar(50),
@Points int
as 
begin
insert into FootballLeague
Values(@Match_Id,@TeamName1,@TeamName2,@Status,@WinningTeam,@Points)
end