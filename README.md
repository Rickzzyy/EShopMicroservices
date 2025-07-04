# 🧱 ASP.NET Core Microservices – DDD, CQRS, Clean Architecture (.NET 8)

This project is a comprehensive implementation of a **microservices architecture** using **.NET 8**, following industry best practices including:

- **Domain-Driven Design (DDD)**
- **CQRS (Command Query Responsibility Segregation)**
- **Clean Architecture** principles
- **Vertical Slice Architecture**

---

## 📦 Features

- Modular microservices with **independent databases**
- **Event-driven communication** using RabbitMQ
- **API Gateway** with Yarp
- **Docker-based** development and deployment
- **Clean separation of concerns** (Domain, Application, Infrastructure, API layers)
- Integration with **PostgreSQL**, **Redis**, **MSSQL**, **SQLite**

---

## 📂 Microservices Overview

| Service             | Description                         |
|---------------------|-------------------------------------|
| Basket.API          | Shopping cart operations            |
| Catalog.API         | Product catalog & search            |
| Discount.API        | Discounts and promotions (gRPC)     |
| Ordering.API        | Order management                    |
| Yarp Gateway        | Unified entry point for APIs        |

---

## 🧱 Tech Stack

- **.NET 8**, **ASP.NET Core**
- **Entity Framework Core**, **Dapper**
- **PostgreSQL**, **Redis**, **MSSQL**, **SQLite**
- **RabbitMQ** for asynchronous communication
- **MediatR** for CQRS & request/response handling
- **AutoMapper**, **FluentValidation**
- **MassTransit** for message-based architecture
- **Serilog** for structured logging
- **Docker / Docker Compose**
- **Yarp API Gateway**
- **MassTransit**
- **gRPC** (for service-to-service calls)
- **ASP.NET Razor**
- **Carter**

---

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Run with Docker Compose

```bash
git clone https://github.com/Rickzzyy/EShopMicroservices.git
cd EShopMicroservices
docker-compose -f docker-compose.yml up --build
