# Snap Game

A Windows Forms (.NET Framework 4.8.1) card game application featuring extensible architecture, clean separation of concerns, and robust unit testing. The project demonstrates modern C# design patterns including Factory, Dependency Injection, and DTOs.

## Features

- Play the Snap card game with configurable number of decks and players.
- Extensible design for adding new card games (e.g., Poker).
- Clean separation between UI, business logic, and data models.
- Uses Unity for dependency injection.

## Project Structure

- `SnapGame/` - Main application source code
  - `SnapGame.cs` - Main Windows Form UI
  - `Classes/` - Business logic and models (`PlayCardSnapGame`, `Deck`, `Player`, `Card`, etc.)
  - `Factory/` - Factory pattern for game instantiation
  - `Interfaces/` - Abstractions for game and service logic
  - `Enums/` - Enum definitions for game types and matching conditions
  - `Program.cs` - Application entry point and DI setup
- `SnapGame.Tests/` - Unit test project
  - Uses MSTest and Moq for mocking


## Getting Started

### Build and Run

1. **Clone the repository:**
2. **Open the solution in Visual Studio.**
3. **Build the solution:**  
`Build > Build Solution` or `Ctrl+Shift+B`
4. **Run the application:**  
Set `SnapGame` as the startup project and press `F5`.

### Usage

- Enter the number of decks and players.
- Select a matching condition.
- Click **Play** to run the game and view results.

## Extending the Game

- To add a new game type:
1. Implement `IPlayCardGame` for your new game.
2. Update `CardGameFactory` to support the new type.
3. Add corresponding unit tests.

## Design Patterns Used

- **Factory Pattern:** Centralized game object creation.
- **Dependency Injection:** Unity container for service resolution.
- **DTO:** Structured result transfer between layers.
- **Interface-Driven Design:** For extensibility and testability.

