# 🚀 Space Shooter Game

A 2D space shooter game built with **Unity**, where players pilot a spaceship, destroy waves of alien enemies, and survive for as long as possible while tracking their kill count and health.

---

## 📖 About

**Space Shooter Game** is a top-down 2D space shooter. Players control a spaceship that fires projectiles at incoming waves of alien enemies. The game tracks the player's health and total kill count as enemies are destroyed.

🎨 Visual assets (spaceship, enemies, and background) are sourced from the Unity Asset Store.

---

## ✨ Features

- 🖱️ Mouse-based ship movement and shooting
- 👾 Three distinct enemy types with unique attack behaviors
- 🚀 Screen-clearing missile ability triggered every 10 kills
- ❤️ Health bar with real-time percentage display
- 💀 Kill counter to track enemies destroyed
- 💥 Explosion effects on enemy destruction
- 🌌 Animated space background with parallax-style visuals
- 🎬 Start screen with a "Start" button to begin the game

---

## 👾 Enemy Types

| Type | Behavior | Range | Attack Speed | Damage |
|------|----------|-------|---------------|--------|
| 🎯 Ranged Sniper | Stays far from the player | Long range | Fast | Low–Medium |
| 🛰️ Mid-Range Attacker | Holds a medium distance | Medium range | Slow | Medium |
| 💢 Melee Rammer | Charges directly into the player | Close range | On contact | High |

---

## 🚀 Special Ability

- After destroying **10 enemies**, the player automatically fires a **missile** that instantly destroys all enemies currently on screen — a powerful screen-clearing mechanic that rewards consistent kills.

---

## 🎮 Controls

| Action | Input |
|--------|-------|
| 🕹️ Move Ship | Mouse Movement |
| 🔫 Shoot | Mouse Click |

---

## 🛠️ Built With

- 🎮 [Unity](https://unity.com/) — Game engine
- 💻 **C#** — Scripting language
- 🧩 Unity 2D Physics, Animation, and UI systems
- 🖼️ Spaceship, enemy, and environment assets from the Unity Asset Store

---

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) installed
- A Unity Editor version compatible with this project (check `ProjectSettings/ProjectVersion.txt` in the repository for the exact version)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/Space-Shooter-Game.git
   ```
2. Open **Unity Hub**
3. Click **Add project from disk** and select the cloned project folder
4. Open the project and allow Unity to import all assets
5. Open the main scene from the `Assets/Scenes` folder
6. Press ▶️ **Play** in the Unity Editor to run the game

---

## 🎯 How to Play

1. Press **Start** on the main menu to begin
2. Move the mouse to steer your spaceship
3. Click to shoot down incoming enemies
4. Watch out for the three enemy types — ranged snipers, mid-range attackers, and melee rammers
5. Avoid enemy contact to preserve your health
6. Chain 10 kills in a row to trigger a screen-clearing missile

---

## 📂 Project Structure

```
Space Shooter Game/
├── Assets/
│   ├── Animation/      # Ship, enemy, and effect animations
│   ├── Scenes/         # Game scenes (Menu, Gameplay)
│   ├── Scripts/        # Game logic (C#)
│   └── ...
├── ProjectSettings/
└── README.md
```

---

## 🤝 Contributing

This is currently a personal/independent project. Suggestions and feedback are welcome — feel free to open an issue on this repository.

---

## 📜 License

No license has been specified for this project yet. All rights reserved unless stated otherwise.

---

## 📬 Contact

For questions or feedback about the project, please open an issue on this repository.
