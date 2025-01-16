# Vehicle Tracking System

This project is a comprehensive solution for vehicle tracking with features such as real-time monitoring, report generation, and maintenance tracking. The system supports Teltonika devices ,CalAmp,Meiligao initially, with the capability to integrate other devices in the future.

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

The **Vehicle Tracking System** allows fleet managers to track vehicles in real-time, generate reports on driving behavior, speed violations, maintenance, and more. The system supports integration with Teltonika GPS devices, providing an intuitive interface for monitoring, tracking, and reporting. Key features include route mapping, driver behavior analysis, and fleet maintenance tracking. The system also allows for future expansion to support additional GPS devices beyond Teltonika.

The system aims to improve fleet management efficiency, reduce costs by monitoring vehicle performance, and enhance driver safety through detailed insights and notifications. It is designed to be scalable and flexible, offering a complete solution for any type of fleet, from small businesses to large corporations.

---

## Features

- **Real-time Vehicle Tracking**:  
  The system enables the real-time tracking of vehicles using GPS technology. The location of each vehicle is updated dynamically, providing accurate and up-to-date information.
  
- **Driver Behavior Reports**:  
  The system can analyze and report on unsafe driving behaviors such as speeding, harsh braking, and rapid acceleration, helping to improve driver safety and reduce accident rates.

- **Maintenance Reports**:  
  Track the maintenance schedules and service history of each vehicle. Receive notifications when maintenance is due to prevent breakdowns and extend the lifespan of the fleet.

- **Daily Trip Reports**:  
  Generate detailed reports for each vehicle’s daily trips, including route, duration, distance, and stops, which can be exported in PDF or Excel formats.

- **Notifications and Alerts**:  
  Receive notifications for speed violations, unsafe driving, and other conditions that are pre-configured. This ensures that managers can act quickly to address any issues.

- **Scalable and Extensible**:  
  The system is designed to support multiple GPS devices, with initial support for Teltonika devices and the ability to add support for other devices in the future.

- **Exportable Reports**:  
  Generate and export reports in various formats (PDF, Excel) for easy sharing and further analysis.

- **Multi-user Access**:  
  Multiple users with different roles can access the system with defined permissions, making it suitable for both small and large teams.

---

## System Requirements

- **Operating System**:  
  The system is designed for use on **Windows**. It can be installed on both Windows Server and desktop versions.

- **Database**:  
  **MySQL** is used for storing all vehicle data, including location data, driver behavior, and reports.

- **Backend**:  
  The backend is built using **ASP.NET Core** for handling APIs, authentication, and business logic.

- **Frontend**:  
  The user interface can be built using **React** or any other modern front-end framework that interacts with the backend via API calls.

- **GPS Devices**:  
  **Teltonika GPS devices** are supported initially. The system is designed to be extensible to support additional devices as needed.

- **Other Software**:  
  - .NET Core SDK (for backend development)
  - Node.js and npm (if using React for frontend)
  - MySQL Workbench (or similar MySQL client)

---

## Installation

### Prerequisites
Before installing, ensure you have the following installed:

- **.NET Core SDK**:  
  [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet)

- **MySQL Database**:  
  [Download MySQL](https://dev.mysql.com/downloads/)

- **Node.js**:  
  [Download Node.js](https://nodejs.org/)

### Steps to Install

1. **Clone the repository**:  
   First, clone the repository to your local machine:
   ```bash
   git clone https://github.com/reco2008/smart-tracking-ai.git

Set up the database:

Create a new MySQL database and import the vehicle_tracking.sql script into it. This script will create all necessary tables for tracking vehicles and storing data.
Configure the Backend:

Open the backend project in Visual Studio or VS Code.
Update the appsettings.json file to reflect your MySQL connection string and any other environment-specific configurations.
Set up the Frontend (Optional):

If you're using a separate frontend (e.g., React), navigate to the frontend folder and install dependencies:
bash
Copy code
npm install
Make sure the frontend is properly connected to the backend API.
Run the Backend:
Build and run the backend using the following command:

bash
Copy code
dotnet run
Run the Frontend (if applicable):
For React, start the frontend application:

bash
Copy code
npm start
Access the Application:

Open your browser and navigate to http://localhost:5000 to access the vehicle tracking system.
Usage
Real-time Tracking
Once the application is running, access the dashboard to view the real-time location of all vehicles. The map will update dynamically to show the current location of each vehicle based on GPS data.

Reports
To generate reports, navigate to the Reports section of the application. Select the desired report type (e.g., daily trips, driver behavior) and specify the date range or vehicle. Reports can be exported in PDF or Excel formats.

Notifications and Alerts
Set up custom alerts under the Settings section. You can configure notifications for speed violations, unsafe driving, and other conditions that need to be monitored.

Managing Vehicles and Drivers
You can add, remove, and update vehicle and driver details in the Fleet Management section. Each vehicle can be linked to a driver, and maintenance schedules can be tracked.

Contact
For any questions or issues, feel free to reach out to me at reco200814@gmail.com
.
