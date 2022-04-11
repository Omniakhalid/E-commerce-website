# E-commerce-website
 
it is an ecommerce web based application for buying and selling products with different categories over internet and also provide online payment.
via stripe
<hr>
<h3> Technologies </h3>
ASP.NET MVC Core 5, EF Core, HTML ,css, js and strip payment gateway
<hr>
<h3> Patterns </h3>
DI, Repository Pattern and MVC
<hr>
<h3> Roles </h3>

- #### Admin :
  
  View all Vendors, Users and change the role of user or vendor .

- #### Vendor :
  
  makes crud operations on Products and add options for every product and view all orders.

- #### Buyer :
  
  search based on categories, buy and pay for products.
  
  ## Quick install

- check connection string
  
  ```C#
  "MyConn": "Data Source=.;Initial Catalog=OnlineShopping;Integrated Security=True",
  "E_commerce_websiteContextConnection": "Server=(LocalDb)\\MSSQLLocalDB;Database=E-commerce-website;Trusted_Connection=True;MultipleActiveResultSets=true"
  ```

- open terminal and write this command 
  
  ```C#
  update-database -context OnlineshoppingContext
  update-database -context E_commerce_websiteContext
  ```

- run the appliction and everything should be running perfectly
