# Circle and Rectangle Management System

## Overview
This is a simple console-based C# application that allows users to manage circles and rectangles. The program provides functionalities to add new shapes, list existing shapes, and calculate various statistics like the total area and the percentage of area occupied by circles and rectangles.

<img width="535" alt="Screenshot 2024-12-21 at 8 21 41 PM" src="https://github.com/user-attachments/assets/e2e698ad-d9bf-4fc7-af4d-84fea5ed4ae3" /> <img width="535" alt="Screenshot 2024-12-21 at 8 20 46 PM" src="https://github.com/user-attachments/assets/498c7123-8550-47b8-8adf-661a2f45cb20" />




The system allows the user to:
- Add circles with specified diameters.
- Add rectangles with specified height and width.
- List all shapes in ascending order by their unique IDs.
- View statistics like the total number of shapes, total area, and area percentages occupied by circles and rectangles.

## Features
- **Add a Circle**: Allows the user to input the diameter and creates a new circle.
- **Add a Rectangle**: Allows the user to input the height and width and creates a new rectangle.
- **List Items**: Lists all the circles and rectangles sorted by their IDs.
- **Get Statistics**: Displays total shapes, total area, and area percentages for circles and rectangles.
- **Exit**: Exits the program.

## Classes

### Circle
- **Id**: A unique identifier for each circle.
- **Diameter**: The diameter of the circle.

#### Methods:
- **Area()**: Calculates and returns the area of the circle.
- **Display()**: Displays the circle’s information.

### Rectangle
- **Id**: A unique identifier for each rectangle.
- **Height**: The height of the rectangle.
- **Width**: The width of the rectangle.

#### Methods:
- **Area()**: Calculates and returns the area of the rectangle.
- **Display()**: Displays the rectangle’s information.

### Program
- Main entry point of the application.
- Provides a menu-driven interface for the user to interact with the system.

## How to Use
1. Clone the repository or download the files to your local machine.
2. Open the project in Visual Studio or your preferred C# IDE.
3. Build and run the program.
4. Use the menu options to interact with the application:
   - Select option 1 to add a circle.
   - Select option 2 to add a rectangle.
   - Select option 3 to list all the shapes.
   - Select option 4 to view statistics.
   - Select option 5 to exit the program.
