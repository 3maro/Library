# Library API

Welcome to the Library API project! This API provides endpoints to manage books, quotes, and user authentication.

## Table of Contents

- [Description](#description)
- [API Documentation](#api-documentation)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Description

The Library API is a RESTful web service built using ASP.NET Core. It allows users to manage books and quotes, as well as perform user authentication. The API is designed to handle CRUD operations for books and quotes, and it provides authentication mechanisms using JWT tokens.

## API Documentation

For testing and interacting with the backend API, you can use the provided Postman collection file `BookApi.postman_collection.json`. This collection includes a set of sample API requests and responses that you can import into Postman.

To use the Postman collection:

1. Download the `BookApi.postman_collection.json` file from the repository.

2. Open Postman.

3. Click on "Import" in the top-left corner of Postman.

4. Select the downloaded `BookApi.postman_collection.json` file.

5. Once imported, you will have access to a variety of API endpoints that correspond to the features of the library application. You can use these requests to test the functionality of the backend API.

Please note that you should have the backend server running or deployed in order to successfully test the API endpoints using Postman.


## Getting Started

To run the Library API locally on your machine, follow these steps:

1. Clone this repository: `git clone https://github.com/3maro/Library.git`
2. Navigate to the project directory: `cd Library`
3. Update the connection string in `appsettings.json` to match your database setup.
4. Run the migrations to create the database: `dotnet ef database update`
5. Build and run the application: `dotnet run`

The API will be accessible at `http://localhost:5000`.

## API Endpoints

The following are some of the main API endpoints available:

- `GET /api/books`: Retrieve a list of all books.
- `GET /api/quotes`: Retrieve a list of all quotes.
- `POST /api/authentication/register`: Register a new user.
- `POST /api/authentication/login`: Authenticate and obtain a JWT token.
- ... (add more as needed)

For a complete list of available endpoints and their descriptions, you can refer to the source code or use a tool like Swagger.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- JSON Web Tokens (JWT) for authentication
- AutoMapper for object mapping
- ... (add more as needed)

## Contributing

Contributions to this project are welcome! If you find any issues or want to add new features, please feel free to open a pull request or submit an issue.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
