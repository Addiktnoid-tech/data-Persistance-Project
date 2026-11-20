# Breakout — Unity Data Persistence Project

A Breakout-style arcade game developed with Unity and C# as part of the Unity Learn Data Persistence challenge.

The project explores data management, object-oriented programming, scene management, and persistent data storage.

## Features

- **Player Name:** Enter and save a player name through the main menu.
- **Scene Management:** Navigate between the main menu, gameplay, and high score screens.
- **Data Persistence Between Scenes:** Maintain player information while navigating between scenes.
- **Persistent Data Storage:** Save and load player data using JSON files.
- **High Score System:** Store and display a ranking of the five highest scores.
- **Game Over Screen:** Display the end-of-game interface and allow players to return to the menu.
- **Quit Game:** Exit the standalone application through the main menu.

## Technologies

- Unity
- C#
- JSON
- Unity UI
- Unity Scene Management
- Unity Input System

## Data Persistence

The project uses a custom save system based on JSON serialization.

Player information and high scores are stored locally using Unity's `Application.persistentDataPath`, allowing data to remain available between gameplay sessions.

A persistent player session also maintains relevant information while transitioning between scenes.

## How to Play

1. Launch the game.
2. Enter a player name.
3. Start a new game.
4. Play Breakout and try to achieve the highest score.
5. Check the High Score screen to see the ranking.

## Project Status

Completed as a Unity Learn Data Persistence challenge, with additional features such as a high score ranking system and a custom menu interface.