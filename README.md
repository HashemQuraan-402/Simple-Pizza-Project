# Pizza Ordering Desktop Application

A Windows Forms desktop application for configuring and pricing a pizza order. The interface updates the order summary and total price as the user changes the size, crust, toppings, dining option, and quantity.

## Features

- Small, medium, and large pizza sizes
- Thin and thick crust options
- Multiple toppings, including extra cheese, mushrooms, tomatoes, onions, olives, and green peppers
- Eat-in and take-out options
- Quantity selection
- Real-time order summary and price calculation
- Confirmation dialog before submitting an order
- Reset option for starting a new order

## Technologies

- C#
- Windows Forms
- .NET Framework 4.8
- Visual Studio

## Prerequisites

- Windows 10 or later
- Visual Studio 2022 with the **.NET desktop development** workload
- .NET Framework 4.8 targeting pack

## Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/HashemQuraan-402/pizza-ordering-winforms.git
   ```

2. Open `PizzaProject.sln` in Visual Studio.
3. If Visual Studio asks to restore or retarget the project, accept the .NET Framework 4.8 configuration.
4. Select **Build > Build Solution**.
5. Press `F5` to run with debugging, or `Ctrl+F5` to run without debugging.

## Project Structure

```text
pizza-ordering-winforms/
├── Properties/
├── App.config
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── PizzaProject.csproj
├── PizzaProject.sln
├── Program.cs
├── .gitignore
└── README.md
```

## Data and Configuration

The application uses in-memory state only. It does not connect to a database, external API, or payment service, and closing the application clears the current order.

## Current Scope

This is an educational ordering-interface project. Order persistence, authentication, inventory management, online payment, and automated tests are outside its current scope.

## Future Improvements

- Extract pricing rules into a separate domain service
- Add unit tests for price calculations
- Validate quantity before order confirmation
- Store menu configuration outside the UI layer
- Add receipt persistence and order history

## Author

**Hashem Quraan**

- [GitHub](https://github.com/HashemQuraan-402)
- [LinkedIn](https://www.linkedin.com/in/hashem-quraan-b561453ab)
