# MathGame

MathGame is a console-based application that allows users to play various math games to improve their arithmetic skills. The project is built using C# and targets .NET 8.0.

## Features

- **Multiple Game Types**: The application includes several types of math games:
  - Addition
  - Subtraction
  - Multiplication
  - Division
  - Random Game (a mix of all game types)

- **Difficulty Levels**: Users can select different difficulty levels for each game:
  - Easy
  - Medium
  - Hard

- **Game History**: The application keeps track of previous game results, allowing users to view their past performance.

## How to Play

1. Run the application.
2. Enter your name.
3. Select a game type from the menu.
4. Choose a difficulty level.
5. Answer the math questions presented.
6. View your score and game history.

## Code Structure

- **Menu.cs**: Handles the display and navigation of the main menu.
- **GameEngine.cs**: Contains the logic for playing the games and managing game rounds.
- **IGame.cs**: Interface that defines the structure for all game types.
- **AdditionGame.cs, SubtractionGame.cs, MultiplicationGame.cs, DivisionGame.cs, RandomGame.cs**: Implementations of the `IGame` interface for each game type.
- **Helpers.cs**: Utility functions for the application.
- **Program.cs**: Entry point of the application.
