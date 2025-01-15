# Vehicle Tracking System

This project is a comprehensive solution for vehicle tracking with features such as real-time monitoring, report generation, and maintenance tracking. The system supports Teltonika devices initially, with the capability to integrate other devices in the future.

## Table of Contents

1. [Project Overview](#project-overview)
2. [Features](#features)
3. [System Requirements](#system-requirements)
4. [Installation](#installation)
5. [Usage](#usage)
6. [Development Stages](#development-stages)
7. [Contributing](#contributing)
8. [License](#license)

---

## Project Overview

The Vehicle Tracking System allows fleet managers to track vehicles in real-time, generate reports on driving behavior, speed violations, maintenance, and more. It provides detailed insights into daily trips, driver performance, and vehicle condition.

---

## Features

- **Real-time Vehicle Tracking**: Track the location of vehicles using GPS devices (Teltonika supported initially).
- **Driver Behavior Reports**: Analyze unsafe driving behavior (e.g., speeding, harsh braking).
- **Maintenance Reports**: Track vehicle maintenance and service history.
- **Daily Trip Reports**: View detailed daily reports for each vehicle.
- **Notifications**: Receive alerts for speed violations, unsafe driving, and other custom conditions.
- **Exportable Reports**: Generate and export reports in PDF and Excel formats.
- **Scalable**: Supports additional devices beyond Teltonika in future updates.

---

## System Requirements

- **Operating System**: Windows
- **Database**: MySQL
- **Backend**: ASP.NET Core
- **Frontend**: React (or any front-end framework for better UI)
- **GPS Devices**: Teltonika (initially, with potential for other devices)

---

## Installation

### Prerequisites
- Install **.NET Core SDK**: [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet)
- Install **MySQL Database**: [Download MySQL](https://dev.mysql.com/downloads/)
- Clone the repository:  
  ```bash
  git clone https://github.com/reco2008/smart-tracking-ai.git

Steps to Install
Set up the database:
Import the vehicle_tracking.sql script into your MySQL database.
Configure the Backend:
Open the project in your preferred IDE (Visual Studio/VS Code).
Modify the appsettings.json file to match your database configuration.
Run the Backend:
Build and run the ASP.NET Core backend API.
Configure the Frontend (optional, if using a separate frontend framework):
Build the frontend project using React or any other preferred frontend technology.
Make sure the frontend communicates with the backend API endpoints.
Run the application:
Launch the application, and you should be able to start tracking vehicles, generating reports, and more.
Usage
Real-time Tracking:

Access the vehicle tracking dashboard to see the live locations of vehicles.
Reports:

Generate reports from the sidebar menu for daily trips, driver performance, maintenance, and more.
Notifications:

Set up custom notifications based on speed or driving behavior.
Export Reports:

Export reports to PDF or Excel format directly from the report page.
Development Stages
The project is divided into several stages for organized development:

1. Analysis and Design (Jan 15 - Jan 20)
Define system requirements and initial designs.
2. Development Basic (Jan 21 - Feb 3)
Develop the database, backend APIs, and frontend user interface.
3. Integration and Testing (Feb 4 - Feb 10)
Test the system with Teltonika devices and perform performance checks.
4. Advanced Features (Feb 11 - Feb 17)
Implement additional reports and UI enhancements.
5. Final Testing and Delivery (Feb 18 - Feb 23)
Perform final testing, bug fixes, and prepare the project for delivery.
Contributing
If you'd like to contribute to this project, feel free to fork the repository and create a pull request. All contributions are welcome!

License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any questions or issues, feel free to reach out to me at reco200814@gmail.com.

markdown
Copy code

