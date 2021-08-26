# REST API sample .Net

api built for basic learning with  asp net core 3 + ef core 3

# Request

BaseURL: [https://localhost:5001/v1](https://localhost:5001/v1)

# Category

```json
GET /categories

{
  "id": Integer,
  "title": String,
  "description": String,
  "price": Integer,
  "categoryId": Integer,
  "category": {
    "id": Integer,
    "title": String
  }
}
```

```json
POST /categories

{
	"title":String
}
```

# Product

```json
GET /products/{id}

{
  "id": Integer,
  "title": String,
  "description": String,
  "price": Integer,
  "categoryId": Integer,
  "category": {
    "id": Integer,
    "title": String
  }
}
```

```json
GET /products

{
  "id": Integer,
  "title": String,
  "description": String,
  "price": Integer,
  "categoryId": Integer,
  "category": {
    "id": Integer,
    "title": String
  }
}
```

```json
POSt /products

{
  "title": String,
  "description": String,
  "price": Integer,
  "categoryId": Integer,
}
```
