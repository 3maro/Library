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
**Note:** The API is also deployed and accessible at the following URL: [https://libraryapiapp.azurewebsites.net/](https://libraryapiapp.azurewebsites.net/)



## API Endpoints

Here are some of the main API endpoints available:

- `GET /api/books`: Retrieve a list of all books.
- `GET /api/books/{id}`: Retrieve details of a specific book.
- `POST /api/books`: Add a new book to the library.
- `PUT /api/books/{id}`: Update information for a specific book.
- `DELETE /api/books/{id}`: Delete a book from the library.

- `GET /api/quotes`: Retrieve a list of all quotes.
  
- `POST /api/authentication/register`: Register a new user.
- `POST /api/authentication/login`: Authenticate and obtain a JWT token.

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
