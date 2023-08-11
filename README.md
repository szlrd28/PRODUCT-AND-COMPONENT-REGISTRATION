# PRODUCT-AND-COMPONENT-REGISTRATION

Specification

PRODUCT AND COMPONENT REGISTRATION
Boards
• spare parts
      o id (autoincrement)
      o name o weight in grams
      o price
• products o id (autoincrement)
      o name o weight in grams
      o price
  • product-component switchboard
      o product id
      o part id
      o quantity

The boards describe the individual components, and when the product is applied, its id and name must be given. The product is assembled by selecting the parts that make up the product and their number, the weight of the product is given by the sum of the weight of the parts, the price is the sum of the price of the parts plus 10% assembly cost.

  Tasks The tasks must be carried out on a web interface.
    1. When starting the program, check the following
            a. DB existence, if not, create it
            b. Existence of tables, if not created
            c. If there is a DB and table, do not delete the data
    2. Application of components
            a. Recording
            b. Modification (if price or weight is changed, it should also be changed to the correct data in the products)
            c. Deletion
            d. Do not delete a component that is included in a product
            e. When changing the weight or price of the component, the weight and price of the products in which the component is included will automatically change
    3. Application of products
            a. Recording
            b. Amendment
            c. Deletion
            d. You only need to record the name of the product, as the ID should be created automatically, the weight and price are changed for the parts
            e. You must be able to add the appropriate parts, with the number of pieces that make up the product.
4. Listing of products
            a. ABC in order, name, total weight, price, parts list, with number of pieces Internet Application Development b. In order of price, name, total weight, price, parts list, with number of pieces
            c. Name, total weight, price, list of parts in order of weight, with number of pieces
            d. Click on the name of the product to change the corresponding product
5. List of components
            a. ABC in order, name, total weight, price, in which products it occurs
            b. In order of price, name, total weight, price, in which products it occurs
            c. In order of weight, name, total weight, price, in which products it occurs
            d. Click on a component to change the specified component
            e. Click on a product to change the corresponding product
