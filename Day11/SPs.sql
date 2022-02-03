create table tblPizzas
(id int identity(1,1) primary key,
name varchar(20),
IsVeg bit,
price float)

create proc proc_InsertPizza(@pname varchar(20), @veg bit,@pprice float)
as
begin
  insert into tblPizzas(name,IsVeg,price) values(@pname,@veg,@pprice)
end

create proc proc_UpdatePizzaPrice(@pid int,@pprice float)
as
begin
  update tblPizzas set price = @pprice where id = @pid
end

create proc proc_GetPizzaByID(@pid int)
as
begin
  Select * from tblpizzas where id = @pid
end

create proc proc_GetAllPizzas
as
begin
  Select id,name,IsVeg,round(price,2) from tblpizzas
end

proc_GetAllPizzas

proc_InsertPizza 'ABC',1,12.4

proc_GetPizzaByID 1

proc_UpdatePizzaPrice 1, 20.4

truncate table tblPizzas