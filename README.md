# 🛡️ ASP.NET Core JWT CRUD API (In-Memory + Docker + Swagger)

This is a simple ASP.NET Core Web API project that demonstrates:

- ✅ JWT Authentication
- 🔁 CRUD operations with in-memory data (no database)
- 🐳 Dockerized deployment
- 🌐 Swagger UI for API testing

---
## 📂 Project Structure

```yaml
dockerize-aspNetCore-jwt-api/
├── Controllers/
│   ├── AuthController.cs
│   └── ProductsController.cs
├── Models/
│   ├── User.cs
│   └── Product.cs
├── Services/
│   ├── UserService.cs
│   └── ProductService.cs
├── Helpers/
│   └── JwtHelper.cs
├── Program.cs
├── Dockerfile
└── README.md
```




---

## 🚀 How to Run

### 🔧 Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/)

### 🐳 Build Docker Image

```bash
docker build -t jwt-api .
```

### Run Docker
```bash
docker run -p 3000:80 jwt-api
```

> Visit Swagger UI at:  
> 👉 **http://localhost:3000/swagger**

---

## 🔐 JWT Authentication Flow

1. **Register a user**  
   `POST /api/auth/register`

2. **Login**  
   `POST /api/auth/login`  
   ✅ Returns a **JWT token**

3. **Use token in Swagger**  
   - Click **"Authorize"** on Swagger UI
   - Enter `Bearer <your_token>`

---

## 🧪 API Endpoints

### 🛂 Authentication

| Method | Endpoint              | Body                        |
|--------|-----------------------|-----------------------------|
| POST   | `/api/auth/register`  | `{ "username": "", "password": "" }` |
| POST   | `/api/auth/login`     | `{ "username": "", "password": "" }` |

### 📦 Products (🔒 Requires JWT)

| Method | Endpoint         | Description        |
|--------|------------------|--------------------|
| GET    | `/api/products`  | Get all products   |
| GET    | `/api/products/1`| Get product by ID  |
| POST   | `/api/products`  | Add a new product  |
| PUT    | `/api/products/1`| Update product     |
| DELETE | `/api/products/1`| Delete product     |

---

## 📌 Notes

- All product data is stored **in-memory** and is lost when the app stops.
- JWT secret key is configured in `Program.cs`.

---

## 🙌 Author

**Jervie Marquez**  
[GitHub Profile](https://github.com/jerviechronix)  
📫 Feel free to fork or star this project!

---

## 📝 License

MIT — free to use for learning, demo, and personal projects.




