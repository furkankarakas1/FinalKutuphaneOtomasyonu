use BikeStores		




select * from production.products

alter proc getin @ProducAdi varchar(255),
@prid int
as 
select * from production.products
where product_name like '%' + @ProducAdi + '%'
and product_id like  '%' + @prid + '%'

As you can see, we last our fourth query

