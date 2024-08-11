# ASP.NET 8 JWT Bearer Authentication Example

This project is a basic example of how to implement JWT Bearer Authentication in an ASP.NET 8 application using C#. It is intended for educational purposes to help you understand the core concepts of authorization and authentication with JWT.

## Features

- **Basic JWT Bearer Authentication**: Implemented for securing API endpoints.
- **ASP.NET 8**: Utilizes the latest version of ASP.NET for modern development practices.
- **C#**: The primary language used for the implementation.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

## Code Overview

- **Program.cs**: Configures services and the HTTP request pipeline. Includes JWT authentication configuration.
- **Controllers**: Contains example endpoints to demonstrate authentication and authorization.
- **Models**: Defines the data models used in the application.

## Testing the API

- **Get JWT Token**

  Make a POST request to `/v1/login` with your user credentials to obtain a JWT token.

- **Access Protected Endpoints**

  Include the JWT token in the `Authorization` header as a Bearer token to access protected endpoints.

## Contributing

Feel free to open issues or submit pull requests if you have suggestions for improvements or find bugs.

## License

This project is licensed under the [MIT License](LICENSE).
