# Dapr in Action: A Simple Example to Get You Started 🚀

This repository contains a simple C# demo app that demonstrates the power of Dapr for microservices ([Blog Post](https://medium.com/p/50209c03c704/edit)). The app consists of two ASP.NET Core Web API services and a C# Console App. The first service generates a random number, and the second one squares it. We use Dapr for service invocation and state management.

## Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Dapr CLI](https://docs.dapr.io/getting-started/)

## Project Structure

- **NumberGenerator**: An ASP.NET Core Web API service that generates a random number.
- **SquaringService**: An ASP.NET Core Web API service that squares a given number.
- **DaprExampleApp**: A C# Console App that invokes the two services and saves the generated number and its square using Dapr's state management

## Getting Started
1. Clone the repository:
```
git clone https://github.com/Westmorland/NumberGenerator.git
cd NumberGenerator
```

2. Run the Number Generator service with Dapr:
Open a terminal, navigate to the `NumberGenerator` folder, and run the following command:

```
dapr run --app-id numbergenerator --app-port 7000 --dapr-http-port 3500 dotnet run
```

3. Run the Squaring Service with Dapr:
Open a new terminal, navigate to the SquaringService folder, and run the following command:

```
dapr run --app-id squaringservice --app-port 7001 dotnet run
```

4. Run the Console App:
Open a third terminal, navigate to the DaprExampleApp folder, and run the following command:

```
dotnet run
```

5. Check the output:
You should see the generated number and its square printed to the console.

## Using the App
The Console App performs the following steps:

1. It generates a random number by invoking the `NumberGenerator` service using Dapr's service invocation API.
2. It squares the generated number by invoking the `SquaringService` using Dapr's service invocation API.
3. It saves the generated number and its square using Dapr's state management API.

Feel free to explore the code, modify the services, or add new features!

## Contributing

We welcome contributions! If you find a bug, have a suggestion, or want to improve the code, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/Westmorland/NumberGenerator/edit/master/LICENSE.txt) file for details.
