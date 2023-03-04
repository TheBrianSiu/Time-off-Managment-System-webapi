## Time-off-Management-System Web API
This project is the backend of a time-off management system that allows employees to submit sick leave and paid time off (PTO) requests. The web API is built using .NET 6 and is responsible for storing and retrieving sick leave and PTO requests, as well as employee data.

## Features
Store sick leave requests in an in-memory database
Store PTO requests in an in-memory database
Store employee data in an in-memory database
Retrieve all sick leave requests
Retrieve all PTO requests
Retrieve all employee data
Authenticate users using JWT
Installation
To run this project on your local machine, you'll need to have .NET 6 SDK installed. Once you have that installed, you can clone the repository and run the following commands:

## Copy code
dotnet restore
dotnet run
This will start the development server and listen for requests on http://localhost:5000.

## Usage
To use the web API, follow these steps:

Authenticate the user by sending a POST request to /api/authenticate with valid credentials. This will return a JWT token.
Create a new sick leave request by sending a POST request to /add/records with the necessary details and the JWT token in the Authorization header.
Create a new PTO request by sending a POST request to /add/records with the necessary details and the JWT token in the Authorization header.
Retrieve all sick leave requests by sending a GET request to /get/sickrecords with the JWT token in the Authorization header.
Retrieve all PTO requests by sending a GET request to /get/ptorecords with the JWT token in the Authorization header.
Retrieve all employee data by sending a GET request to /get/employee with the JWT token in the Authorization header.

## Contribution Guidelines
Contributions to this project are welcome. If you would like to contribute, please follow these guidelines:

Fork the repository and create a new branch for your feature or bug fix.
Make your changes and write tests if applicable.
Ensure all tests pass by running dotnet test.
Submit a pull request with your changes.

## Credits
This project uses the following open-source libraries:

.NET 6
Entity Framework Core

## License
This project is licensed under the MIT license. You can find more information in the LICENSE file.

## API Reference

POST /api/add/records
Adds a new record.

POST /api/add/employee
Adds a new employee.

GET /api/get/ptorecords
Retrieves all PTO records.

GET /api/get/sickrecords
Retrieves all sick leave records.

GET /api/get/records
Retrieves all records.

GET /api/get/employee
Retrieves all employee data.
