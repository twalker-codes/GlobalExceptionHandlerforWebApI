# 🛡️ Global Exception Handler for ASP.NET WebAPI

Effortlessly implement a global error handling pattern in your ASP.NET WebAPI projects to ensure consistent and robust error management.

---

## Features

- **Centralized Error Handling**: Manage exceptions from a single point, reducing redundancy.
- **Custom Exception Responses**: Tailor error messages to client applications for improved clarity.
- **Middleware Integration**: Seamlessly incorporate into the ASP.NET request pipeline.
- **Extensibility**: Easily extend to handle various exception types and logging mechanisms.

---

## Tech Stack

- **Backend**: ASP.NET Core WebAPI
- **Language**: C#
- **Middleware**: Custom ASP.NET Core Middleware

---

## Setup & Installation

**Prerequisites**:

- .NET SDK 6.0 or later
- Docker (optional, for containerization)

**Installation Steps**:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/twalker-codes/GlobalExceptionHandlerforWebApI.git
   cd GlobalExceptionHandlerforWebApI
   ```

2. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the Solution**:
   ```bash
   dotnet build
   ```

4. **Run the Application**:
   ```bash
   dotnet run
   ```

*Optional*: To run the application inside a Docker container:

```bash
docker build -t global-exception-handler .
docker run -p 5000:80 global-exception-handler
```

---

## API Endpoints

| Method | Endpoint         | Description                  |
|--------|------------------|------------------------------|
| GET    | `/api/products`  | Retrieve all products        |
| GET    | `/api/products/{id}` | Retrieve a product by ID   |
| POST   | `/api/products`  | Create a new product         |
| PUT    | `/api/products/{id}` | Update an existing product |
| DELETE | `/api/products/{id}` | Delete a product by ID     |

---

## NuGet Packages

- **Microsoft.AspNetCore.App**: [ASP.NET Core shared framework](https://www.nuget.org/packages/Microsoft.AspNetCore.App/)
- **Swashbuckle.AspNetCore**: [Swagger integration for API documentation](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)

---

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add YourFeature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a Pull Request.

---

## License

This project is licensed under the [MIT License](LICENSE).
