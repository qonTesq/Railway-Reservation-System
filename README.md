# TrainTravel (Railway Reservation System)

## Overview

This is a simple desktop application for reserving train tickets. It allows users to search for trains between selected cities, check seat availability, and book tickets. The application is built using VB.NET for Windows Forms and connects to a Microsoft Access database to manage train schedules, stations, stops, and bookings.

The system supports a limited set of cities (Jaipur, Rajkot, Ahmedabad, Vadodara, Mumbai) and trains for demonstration purposes. Each train has a maximum capacity of 5 passengers per journey to simulate availability constraints.

## Features

- **Welcome Screen**: Entry point with options to book tickets or exit the application.
- **Train Search**: Select origin, destination, travel class, date, and number of passengers to find available trains.
- **Seat Availability Check**: Dynamically calculates available seats based on prior bookings and station sequences.
- **Booking Functionality**: Books tickets if seats are available and updates the database.
- **Database Integration**: Uses OleDb to interact with an Access database containing tables for Bookings, Stations, TrainStops, and Trains.
- **Validation**: Ensures valid inputs (e.g., different origin/destination, filled fields) and handles errors gracefully.

## Technologies Used

- **Programming Language**: VB.NET
- **Framework**: .NET Framework (Windows Forms)
- **Database**: Microsoft Access (.accdb file: RailwayReservation.accdb)
- **IDE**: Visual Studio

## Setup and Installation

1. **Prerequisites**:
   - .NET Framework installed (version 4.0 or higher).
   - Microsoft Access Database Engine (for OleDb support).
   
2. **Database Setup**:
   - Place the `RailwayReservation.accdb` file in the project directory (or adjust the connection string in the code).
   - The database includes predefined data for stations, trains, and stops.

3. **Running the Application**:
   - Open the project in Visual Studio.
   - Build and run the solution.
   - The application starts with the Welcome Form.

Note: The database path in the code is relative (`Application.StartupPath\..\..\..\data\RailwayReservation.accdb`). Adjust if necessary.

## Code Structure

- **WelcomeForm.vb**: Handles the initial screen with Book and Exit buttons.
- **MainForm.vb**: Core form for searching and booking trains. Includes event handlers for loading data, searching, booking, and database interactions.
- **Database Functions**: Helper methods like `GetTrainIds`, `GetAvailableSeats`, `BookTicket`, `GetStationSequence`, etc., for querying and updating the database.

## Screenshots

<img width="878" height="323" alt="image" src="https://github.com/user-attachments/assets/dfa38e7b-58da-4b5d-b561-8cdd0dca14ff" />

<img width="548" height="452" alt="image" src="https://github.com/user-attachments/assets/f1d3b5d6-d84f-4d07-b439-30766f1477f8" />

<img width="662" height="387" alt="image" src="https://github.com/user-attachments/assets/f3d80a24-f529-457d-8732-bd3f2fd1c5cb" />

## Notes

- This is a student project for educational purposes.
- Seat availability is calculated considering station sequences to handle partial journeys accurately.
- Error handling includes connection issues, invalid inputs, and booking failures.
