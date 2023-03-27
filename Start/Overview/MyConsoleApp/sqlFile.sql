-- You will need to create SELECT statement in conjunction with LIKE.
-- Please list people which have first_name with at least 6 character long
-- select first_name, last_name from names where first_name like '______%'

-- You are the owner of the Grocery Store. All your products are in the database, that you have created after CodeWars SQL excercises!:)
-- Today you are going to CompanyA warehouse
-- You need to check what products are running out of stock, to know which you need buy in a CompanyA warehouse.
-- Use SELECT to show id, name, stock from products which are only 2 or less item in the stock and are from CompanyA.
-- Order the results by product id
-- products table schema
-- id
-- name
-- price
-- stock
-- producent
select p.id,p.name,p.stock
from products p
where p.stock<3 and p.producent='CompanyA'
order by p.id

select top(10) p.customer_id ,p.email,count(pa.payments_count) as payments_count ,sum(pa.amount) as total_amount
from customer p
inner join payment pa on pa.customer_id=p.customer
order by total_amount desc
