----------- Join with Aliases ----------
 -- 19. Retrieve the product name and category name of each product ordered.--
 Select p.product_name , c.category_name
 from products p
 Inner Join categories c
 on p.category_id = c.category_id
 order by p.product_name;