
# 2D Action Adventure Game

### C# Windows Forms | 2D Platformer & Shooting Game

A 2D action-adventure game developed using **C#**, **Windows Forms**, and **.NET Framework 4.7.2**.

The game consists of three levels featuring different environments, enemies, shooting mechanics, jumping, collectible coins, and a final boss encounter.

Players must defeat enemies, avoid obstacles and projectiles, and progress through each level to complete the game.

---

## Game Screenshots

### Level 1 – Mountain Adventure

![Level 1](screenshots/level1.png)

The first level introduces the player to the game's basic movement and shooting mechanics.

**Gameplay Features:**
- Mountain and forest environment.
- Moving enemies.
- Player movement and jumping.
- Shooting mechanics.
- Score tracking.
- Health system.

### Level 2 – Sky Battle

![Level 2](screenshots/level2.png)

The second level introduces additional enemy types and more challenging combat mechanics.

**Gameplay Features:**
- New environment and background.
- Flying enemy that launches projectiles.
- Ground enemies with ranged attacks.
- Multiple enemy interactions.
- Elevator mechanism for level progression.
- Health and score tracking.

### Level 3 – Final Challenge

![Level 3](screenshots/level3.png)

The final level introduces a cave environment with additional obstacles, collectibles, and a boss encounter.

**Gameplay Features:**
- Cave-themed environment.
- Enemy combat.
- Falling fire hazards.
- Collectible coins.
- Ladder movement mechanics.
- Special attack.
- Final boss encounter.
- Win and Game Over screens.

---

## Game Controls

The game is controlled using the keyboard.

| Key | Action |
|-----|--------|
| Left Arrow | Move left |
| Right Arrow | Move right |
| Space + Up Arrow | Jump vertically |
| Space + Right Arrow | Jump forward |
| Space + Left Arrow | Jump backward |
| Z | Fire a single projectile |
| X | Fire three projectiles |
| W | Move upward in Level 3 |
| S | Move downward in Level 3 |
| L | Activate the special attack when available |

### Combat System

The player can use different attacks to defeat enemies:

- **Single Shot (Z):** Fires one projectile.
- **Triple Shot (X):** Fires three projectiles.
- **Special Attack (L):** Activates a horizontal attack after the required coins have been collected.

### Health System

- The player starts with three hearts.
- Collisions with enemies or enemy projectiles reduce health.
- Losing all hearts triggers the Game Over sequence.

---

## Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Main programming language |
| Windows Forms | Desktop application framework |
| .NET Framework 4.7.2 | Application runtime |
| System.Drawing | 2D graphics rendering |
| Visual Studio | Development environment |

### Programming Concepts

- Object-Oriented Programming (OOP)
- Event-Driven Programming
- Keyboard Input Handling
- Collision Detection
- Game State Management
- Sprite Animation
- Timer-Based Game Updates
- 2D Graphics Rendering
- Collections and Lists

---

## Game Architecture

The game uses an event-driven architecture implemented with Windows Forms.

### 1. Game Initialization

The application initializes the player, enemies, backgrounds, health indicators, and other game objects.

### 2. Player Movement

Keyboard events control horizontal movement, jumping, and level-specific actions.

### 3. Game Loop

A Windows Forms Timer updates the game state, including:

- Player jumping.
- Enemy movement.
- Projectile movement.
- Collision detection.
- Health updates.
- Score updates.
- Level transitions.

### 4. Collision Detection

The game checks collisions between:

- Player and enemies.
- Player and enemy projectiles.
- Player and collectibles.
- Player projectiles and enemies.
- Player projectiles and the final boss.

### 5. Level Progression

The game manages three levels using internal state variables.

Each level introduces different gameplay mechanics and environmental challenges.

### 6. Graphics Rendering

The game uses `System.Drawing` to display backgrounds, characters, projectiles, and other game objects.

An off-screen bitmap is used to render the scene before displaying it on the game window.

---

## Installation and Setup

### Requirements

- Windows 10 or Windows 11
- Visual Studio with .NET desktop development tools
- .NET Framework 4.7.2 Developer Pack

### How to Run

**1. Clone the repository**

```bash
git clone https://github.com/YOUR_USERNAME/2D-Action-Adventure-Game.git
```

**2. Open the project**

Open the `.sln` solution file using Visual Studio.

**3. Check the game assets**

Make sure the required images and sprites are available in the application's working directory.

**4. Build the project**

Select:

`Build > Build Solution`

**5. Run the game**

Press `F5` or select `Start` in Visual Studio.

**Note:** The game uses relative paths to load image assets, so the required files must be available when running the application.

---

## Project Structure

```text
2D-Action-Adventure-Game/
│
├── README.md
├── .gitignore
│
├── screenshots/
│   ├── level1.png
│   ├── level2.png
│   └── level3.png
│
└── long game/
    ├── long game.sln
    └── long game/
        ├── Form1.cs
        ├── Form1.Designer.cs
        ├── Program.cs
        ├── App.config
        ├── long game.csproj
        └── Properties/
```

The structure above is a suggested GitHub layout. Required game assets must also be included in the repository.

---

## Key Implementation Details

### Player Movement

Player movement is handled using Windows Forms keyboard events.

The game supports horizontal movement and jumping in multiple directions.

### Enemy System

Different enemy types are introduced throughout the game.

Enemies can move across the screen and launch projectiles toward the player.

### Shooting System

The shooting system supports single and multiple projectiles.

Collision detection determines whether a projectile hits an enemy and updates the game score.

### Collectible System

Coins are introduced in the final level.

Collecting the required coins enables a special attack.

### Boss Encounter

The final level includes a boss with its own projectile attacks and health indicator.

The player must progress through the final encounter to reach the winning condition.

---

## Future Improvements

- Refactor game logic into separate classes.
- Improve enemy movement and collision handling.
- Add a main menu and pause functionality.
- Add sound effects and background music.
- Improve level transitions.
- Organize game assets into dedicated folders.
- Add a gameplay demonstration video.

---

## Learning Outcomes

This project provided practical experience in:

- Building desktop applications using C#.
- Implementing 2D game mechanics.
- Handling keyboard events.
- Managing multiple game states.
- Implementing collision detection.
- Creating enemy and projectile systems.
- Rendering graphics using Windows Forms.
- Organizing gameplay logic using classes and collections.

---

## Project Information

**Project Type:** Academic Game Development Project

**Programming Language:** C#

**Framework:** Windows Forms / .NET Framework 4.7.2

**Number of Levels:** 3

**Platform:** Windows

---

## License

No license has been specified for this project.
