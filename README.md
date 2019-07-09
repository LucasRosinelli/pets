# Pets

**Pets** is a *RESTful API* built with **.NET Core**

## Endpoints

### GET api/product
Get all products.

### GET api/product/{id}
Get product by **id**, where *id* is a *long* number.

### POST api/product
Create a new product.
Body content (JSON):
´´´
{
  "name": "Ball",
  "price": 6.49
}
´´´

### PUT api/product/{id}
Update product by **id**, where *id* is a *long* number.
Body content (JSON):
´´´
{
  "id": 3,
  "name": "Ball",
  "price": 6.49
}
´´´

### DELETE api/product/{id}
Delete product by **id**, where *id* is a *long* number.
