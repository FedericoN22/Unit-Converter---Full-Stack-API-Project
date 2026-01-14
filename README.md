# Unit Converter – Full Stack API Project

This project is a **full-stack web application** built to demonstrate practical understanding of **backend APIs, frontend integration, and clean project architecture** using modern .NET technologies.

It focuses on **real-world fundamentals** rather than frameworks or boilerplate.

---

## 🎯 Project Overview

The application exposes a **REST API** that performs unit conversions for:

* Length
* Weight
* Temperature

A lightweight frontend consumes the API via HTTP requests and displays the results to the user.

The goal of the project is to demonstrate:

* How to design and expose APIs
* How to connect frontend and backend cleanly
* How to structure a maintainable project

---

## 🧱 Architecture

The project follows a **clear separation of concerns**:

```
UnitConverter
│
├── UnitConverter.Api        # Backend (ASP.NET Core Minimal API)
│   ├── Program.cs
│   └── Conversions
│       ├── Length.cs
│       ├── Weight.cs
│       └── Temperature.cs
│
├── UnitConverter.Web        # Frontend
│   ├── html
│   ├── css
│   └── javascript.js
```

### Backend

* Built with **ASP.NET Core Minimal API (.NET 8)**
* Stateless REST endpoints
* Business logic isolated from API layer
* JSON-based communication
* CORS configured for frontend consumption

### Frontend

* Vanilla **HTML, CSS, and JavaScript**
* Uses `fetch` to consume the API
* No business logic on the client
* Easily replaceable by React, Vue, etc.

---

## 🔌 API Design

### Example endpoint

```
GET /convert/length?value=2000&from=m&to=km
```

### Response

```json
{
  "result": 2,
  "from": "m",
  "to": "km"
}
```

### Available endpoints

| Method | Endpoint             |
| ------ | -------------------- |
| GET    | /convert/length      |
| GET    | /convert/weight      |
| GET    | /convert/temperature |

The API uses **query parameters**, follows REST conventions, and returns consistent JSON responses.

---

## 🚀 Running the Project

### Backend

```bash
cd UnitConverter.Api
dotnet run
```

The API will be available at:

```
http://localhost:5296
```

---

### Frontend

The frontend can be served using any static server (e.g. VS Code Live Server).

It communicates with the backend via HTTP using `fetch`.

---

## 🧠 Key Concepts Demonstrated

* REST API design
* ASP.NET Core Minimal APIs
* HTTP and JSON communication
* Query parameter binding
* CORS configuration
* Frontend ↔ backend integration
* Separation of concerns
* Clean and readable code structure

---

## 📌 Why This Project Matters

This project intentionally avoids unnecessary complexity (ORMs, databases, frameworks) to focus on **core backend fundamentals**.

It demonstrates the ability to:

* Design APIs from scratch
* Understand how frontend and backend interact
* Debug real integration issues (CORS, binding, HTTP errors)
* Build projects incrementally and correctly

---

## 🔮 Possible Extensions

* Input validation and structured error responses
* Unit and integration tests
* API versioning
* Dockerization
* Deployment to cloud providers
* Frontend rewrite using React or Vue

---

## 👤 Author

Federico Núñez

---

## 📝 License

This project is provided for educational and demonstration purposes.

https://roadmap.sh/projects/unit-converter
