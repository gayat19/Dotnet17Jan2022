use pubs

--11) Print the first published title in every type
select type,min(pubdate) 'First published' from titles
group by type

--16) Print the author name of books which have royalty more than the average royalty of all the titletes
select concat(au_fname,' ',au_lname) from authors where au_id in
(select au_id from titleauthor where title_id in
(select title_id from titles where royalty>
(select avg(royalty) from titles)))

--17) Print all the city and the number of pulishers in it, only if the city has more than one publisher
select city,count(pub_id) 'No of publishers' from publishers
group by city
having count(pub_id)>1 

--28) Select the store who have taken morethan 2 orders
select stor_id, count(ord_num) 'Number of orders' from sales
group by stor_id
having count(ord_num)>2

--29) Select all the titles and print the first order date (titles that have not be ordered should also be present)
select title, min(ord_date) 
from titles t left outer join sales s
on s.title_id = t.title_id
group by title

--7) print all titles published before '1991-06-09 00:00:00.000'

select * from titles where pubdate < '1991-06-09 00:00:00.000'
