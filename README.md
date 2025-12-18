# IELTScalculator

## 📘 Project Overview

**IELTScalculator** is a .NET-based application designed to calculate and evaluate IELTS exam results. The project follows a clean, layered architecture to ensure maintainability, scalability, and clarity.

---

## 🚀 Features

* Calculate overall IELTS band score
* Modular architecture (Client, Application, Domain, Infrastructure)
* Easy to extend with new calculation rules
* Clean separation of business logic

---

## 🧱 Project Structure

```
IELTScalculator
│
├── IELTScalculator.Application
│   └── Services
│       └── IeltsCalculatorService.cs
│
├── IELTScalculator.Domain
│   └── Models
│       └── IeltsResult.cs
│
├── IELTScalculator.Infrastructure
│   └── Data
│       └── AppDbContext.cs
│
├── IELTScalculator.Client
│   └── Program.cs
│
├── .gitignore
└── IELTScalculator.slnx
```

---

## 🛠️ Technologies Used

* C#
* .NET 6 / .NET 7
* Visual Studio
* Git & GitHub

---

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/USERNAME/IELTScalculator.git
```

2. Open `IELTScalculator.slnx` in **Visual Studio**

3. Set `IELTScalculator.Client` as **Startup Project**

4. Run the application

---

## 🧪 Example Usage

```csharp
var service = new IeltsCalculatorService();
var result = service.Calculate(6.5, 7.0, 6.0, 6.5);
Console.WriteLine(result.OverallBand);
```

---

## 🤝 Contribution

1. Fork the repository
2. Create a new branch (`feature/new-feature`)
3. Commit your changes
4. Open a Pull Request

---

## 📄 License

This project is for educational purposes.

---

## 👤 Author

**Sardor Sanjarovich**
