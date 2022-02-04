use dbPizzaStorefeb22

select * from Pizzas

select cs.Name 'Customer Name', c.CartNumber 'Cart number', 
p.Name 'Pizza Name', p.Price 'Unit Price', 
cp.Quantity 'Qty',
(p.Price*cp.Quantity) 'Amount'
from 
Pizzas p join CartPizzas cp on p.Id=cp.PizzaId
join carts c on c.CartNumber = cp.CartNumber
join Customers cs on c.CustomerNumber = cs.CustomerNumber

select * from Customers