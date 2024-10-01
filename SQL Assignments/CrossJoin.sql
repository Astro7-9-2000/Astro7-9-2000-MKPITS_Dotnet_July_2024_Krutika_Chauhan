---------- Cross Join ---------------
 -- 14. Retrieve all possible combinations of products and categories from the products and categories tables --

 Select p.product_name , c.category_name
 from product p
 cross join categories c;