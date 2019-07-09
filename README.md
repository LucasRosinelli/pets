# Pets

**Pets** is a *RESTful API* built with **.NET Core**.

## Endpoints

On **CLI** (*PowerShell*, *Command Prompt* or *Terminal*), navigate to *src/Pets.Api/* and run `dotnet run` command.

**Pets API** will run on `http://localhost:5000/` and `https://localhost:5001/`.

### List products
Gets a JSON list of existing products.

* **URL**

  /api/product

* **Method:**

  `GET`
  
* **URL Params**

  None

* **Data Params**

  None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `[ { "id": 1, "name": "Squeaky bone", "price": 20.99 }, { "id": 2, "name": "Knotted rope", "price": 12.99 } ]`
 
* **Error Response:**

  None

* **Sample Call:**

  ```javascript
    $.ajax({
      type : "GET",
      url: "/api/product",
      contentType : "application/json", 
      dataType: "json",
      success : function(result) {
        console.log(result);
      }
    });
  ```

### Show product
Gets JSON about a single product.

* **URL**

  /api/product/:id

* **Method:**

  `GET`
  
* **URL Params**

  **Required:**
 
  `id=[long]`

* **Data Params**

  None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ "id": 1, "name": "Squeaky bone", "price": 20.99 }`
 
* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
    **Content:** `{ "errors": { ... }, "title": "One or more validation errors occurred.", "status": 400 }`

  OR

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ "title": "Not Found", "status": 404 }`

* **Sample Call:**

  ```javascript
    $.ajax({
      type : "GET",
      url: "/api/product/1",
      contentType : "application/json", 
      dataType: "json",
      success : function(result) {
        console.log(result);
      }
    });
  ```

### New product
Creates a single product.

* **URL**

  /api/product

* **Method:**

  `POST`
  
* **URL Params**

  None

* **Data Params**

  **Body payload:**
 
  `{ "name": [string, required], "price": [decimal, required] }`

* **Success Response:**

  * **Code:** 201 CREATED <br />
    **Content:** `{ "id": 3, "name": "Ball", "price": 6.49 }`
 
* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
    **Content:** `{ "errors": { ... }, "title": "One or more validation errors occurred.", "status": 400 }`

* **Sample Call:**

  ```javascript
    $.ajax({
      type : "POST",
      url: "/api/product",
      contentType : "application/json", 
      dataType: "json",
      data: JSON.stringify({ "name": "Ball", "price": 6.49 }),
      success : function(result) {
        console.log(result);
      }
    });
  ```

### Change product
Updates a single product.

* **URL**

  /api/product/:id

* **Method:**

  `PUT`
  
* **URL Params**

  **Required:**
 
  `id=[long]`

* **Data Params**

  **Body payload:**
 
  `{ "id": [long, required], "name": [string, required], "price": [decimal, required] }`

* **Success Response:**

  * **Code:** 204 NO CONTENT
 
* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
    **Content:** `{ "errors": { ... }, "title": "Bad Request", "status": 400 }`

  OR

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ "title": "Not Found", "status": 404 }`

* **Sample Call:**

  ```javascript
    $.ajax({
      type : "PUT",
      url: "/api/product/3",
      contentType : "application/json", 
      dataType: "json",
      data: JSON.stringify({ "id": 3, "name": "Ball", "price": 5.99 }),
      success : function(result) {
        console.log(result);
      }
    });
  ```

### Remove product
Deletes a single product.

* **URL**

  /api/product/:id

* **Method:**

  `DELETE`
  
* **URL Params**

  **Required:**
 
  `id=[long]`

* **Data Params**

  None

* **Success Response:**

  * **Code:** 204 NO CONTENT
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ "title": "Not Found", "status": 404 }`

* **Sample Call:**

  ```javascript
    $.ajax({
      type : "DELETE",
      url: "/api/product/3",
      contentType : "application/json", 
      dataType: "json",
      success : function(result) {
        console.log(result);
      }
    });
  ```
