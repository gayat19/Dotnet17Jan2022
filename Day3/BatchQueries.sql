use Northwind

begin
declare 
  @score int,
  @dob datetime,
  @name varchar(20)
  set @dob = '1982-10-19'
  set @score = 100
  set @name = 'Gayathri Mahadevan'
  set @score = @score - 20
  print 'Hello '+@name
  print @score
  if(@score>70)
	print 'Pass'
  else
    print 'fail'
  print 'My Date of birth is '+ cast(@dob as varchar(20))
end

begin
declare 
 @count int
 set @count = 0
  while(@count<10)
  begin
	print @count
	set @count = @count +1
  end
end

create procedure proc_FirstProcedure
as
begin
   print 'Hello frm procedure'
end

exec proc_FirstProcedure

create proc proc_PrintResult(@score int)
as
begin

 if(@score>70)
	print 'Pass'
  else
    print 'fail'
end

exec proc_PrintResult 60



alter proc proc_PrintResult(@score int,@name varchar(20))
as
begin
print 'Hello '+@name
 if(@score>70)
	print 'Pass'
  else
    print 'fail'
end

exec proc_PrintResult 90, 'Tim'

create proc proc_calculate(@amount float,@tax float out)
as
begin
    print 'Calculating......'
    set @tax = @amount *10.2/100
	print 'Done'
end

declare @giventax float
exec proc_calculate 10000, @giventax out
print  @giventax

select * from [Order Details]

create proc proc_PrintPayable(@OrderNumber varchar(5))
as
begin
   Declare
   @CustName varchar(20),
   @Gross float,
   @discount float,
   @fright float,
   @netPrice float
   set @CustName = (select ContactName from Customers where CustomerID 
					=(select CustomerID from Orders where OrderID = @OrderNumber))
   print 'Hello '+ @CustName
   set @Gross = (select sum(unitprice*quantity) from [Order Details] where OrderID = @OrderNumber)
   set @discount = (select sum(Discount) from [Order Details] where OrderID = @OrderNumber)
   if(@discount >0)
       set @Gross = @Gross -(@Gross*@discount/100)
   set @fright = (select Freight from Orders where OrderID  = @OrderNumber)
   set @netPrice = @Gross +@fright
   print 'Gross amount '+cast(@gross as varchar(20))
   print 'Freight amount '+cast(@fright as varchar(20))
   print '-------------------------'
   print 'Net Price '+ cast(@netPrice as varchar(20))
end

exec proc_PrintPayable '10248'


create proc proc_FetchAllCustomers
as
  select * from Customers

exec proc_FetchAllCustomers

create table tblSimple
(f1 int primary key,
f2 varchar(20))

create proc proc_InsertIntoSimple(@f1 int,@f2 varchar(20))
as
  insert into tblSimple values(@f1,@f2)

exec proc_InsertIntoSimple 101,'Hello'



create table tblStatus
(f1 int,
msg varchar(20))

begin tran
   insert into tblSimple values(103,'Check hello')
   insert into tblStatus values(103,'Success')
   if((select count(f1) from tblSimple where f2 = 'Check hello')>0)
      rollback
   else
     commit

alter proc proc_Transaction(@f1 int,@f2 varchar(20))
as
begin
    begin tran
	declare @count int
	set @count = (select count(f1) from tblSimple where f2 = @f2)
	   insert into tblSimple values(@f1,@f2)
	   insert into tblStatus values(@f1,'Success')
	   if(@count>0)
		  rollback
	   else
		 commit
end

exec proc_Transaction 105,'NewHello'

select * from tblSimple
select * from tblStatus

--create a stored procedure that will calculate total salary 
--take input of basic, Dearness allowance(da), House Rent Allowance(hra), deductions and the nnumber of leaves
--if the number of leave is more than 2 deduct the pay for the extra days and calculate teh nett salary

create proc proc_calTotalSalary(@basic float, @da float, @hra float, @deduction float, @numLeaves int)asbegin	Declare		@nettSalary float,		@grossSalary float	set @grossSalary = @basic + @da + @hra - @deduction	if(@numLeaves > 2)	begin	declare 		@perDaySal float		set @perDaySal = @grossSalary / 30		set @nettSalary = @grossSalary - ((@numLeaves -2)*@perDaySal)		print 'Leave Deductions '+  cast(((@numLeaves -2)*@perDaySal) as varchar(20))	end	else	   set @nettSalary = @grossSalary	print 'Gross Salary '+cast(@grossSalary as varchar(20))	print '---------------------------------------'	print 'Net Salary '+cast(@nettSalary as varchar(20))end

exec proc_calTotalSalary 10000,5000,3000,1500,2

select * from tblSimple
select * from tblStatus

create function fn_Sample(@num int)
returns int
as
begin
   return @num*@num
end

select dbo.fn_Sample(UnitPrice) from Products

create function fn_CalSal(@basic float, @da float, @hra float, @deduction float, @numLeaves int)returns floatasbegin	Declare		@nettSalary float,		@grossSalary float	set @grossSalary = @basic + @da + @hra - @deduction	if(@numLeaves > 2)	begin	declare 		@perDaySal float		set @perDaySal = @grossSalary / 30		set @nettSalary = @grossSalary - ((@numLeaves -2)*@perDaySal)	end	else	   set @nettSalary = @grossSalary	return @nettSalaryendselect dbo.fn_CalSal(10000,5000,3000,1500,4)create function fn_CalSalTable(@basic float, @da float, @hra float, @deduction float, @numLeaves int)returns @SalTable Table(GrossAmount float,LeaveDeductions float,NetAmount float)asbegin	Declare		@nettSalary float,		@grossSalary float	set @grossSalary = @basic + @da + @hra - @deduction	if(@numLeaves > 2)	begin	declare 		@perDaySal float		set @perDaySal = @grossSalary / 30		set @nettSalary = @grossSalary - ((@numLeaves -2)*@perDaySal)		insert into @SalTable values(@grossSalary,((@numLeaves -2)*@perDaySal),@nettSalary)	end	else	begin	   set @nettSalary = @grossSalary	   insert into @SalTable values(@grossSalary,0,@nettSalary)	end	returnendselect * from dbo.fn_CalSalTable(10000,5000,3000,1500,4)select * from tblSimple
select * from tblStatus

create trigger trg_InsertCheck
on tblSimple
for Update
as
begin
	print 'Hello'
end

drop trigger trg_InsertCheck
insert into tblSimple values(106,'dgfd')
update tblSimple set f2 = 'ddd' where f1 =106

create table account
(accno int primary key,
balance float)

create table trans
(tranno int primary key,
fromacc int references account(accno),
toacc int references account(accno),
amount float,
status varchar(100))

insert into account values(101,5000)
insert into account values(102,1000)
insert into account values(103,10000)


create trigger trg_Transact
on trans
for insert
as
begin
     declare @bal float,@check float,@credit float
	 set @bal = (select balance from account where accno =(select fromacc from inserted))
	 set @credit = (select amount from inserted)
	 set @check = @bal - (select amount from inserted)
	 if(@check <500)
		update trans set status = 'Failed' where tranno = (select tranno from inserted)
	 else
	 begin
	   update account set balance = @check where accno =(select fromacc from inserted)
	   update account set balance = balance + @credit where accno =(select toacc from inserted)
	   update trans set status = 'Success' where tranno = (select tranno from inserted)
	end
end


select * from account
select * from trans

insert into trans values(3,101,102,3100,null)

declare 
@account int,
@Balance float

DECLARE cur_account CURSOR FOR select * from account

OPEN cur_account

FETCH NEXT FROM cur_account INTO @account,@balance

while(@@FETCH_STATUS =0)
begin
   print 'Account number : '+ cast(@account as varchar(20))
   print 'Account Balance : '+ cast(@Balance as varchar(20))
   print '-----------------------------------'
  
	   declare @amount float, @status varchar(20)
	   DECLARE cur_tran CURSOR FOR select amount,status from trans where fromacc = @account

	   OPEN cur_tran

	   FETCH NEXT FROM cur_tran INTO @amount,@status
	    
	   while(@@FETCH_STATUS =0)
	   begin
		   print '               Amount transffered : '+ cast(@amount as varchar(20))
		   print '               Transaction status : '+ @status
		   print '-----------------------------------'
		   FETCH NEXT FROM cur_tran INTO @amount,@status
	   end 

	   CLOSE cur_tran
	   DEALLOCATE cur_tran
   FETCH NEXT FROM cur_account INTO @account,@balance
end

CLOSE cur_account
DEALLOCATE cur_account