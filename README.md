# 🍔 Food Wars

A fast-paced food stall simulation game built with **C# Windows Forms**. Serve customers quickly and accurately before the timer runs out!

---

## 🎮 Gameplay Overview

Players manage a food stall by fulfilling customer orders in the correct sequence. Each difficulty level increases the number of customers and time limit. Earn income by serving correct orders — and don't let customers wait too long or their mood will drop!

---

## ✨ Features

- **4 Difficulty Levels** — Easy, Medium, Hard, Impossible
- **3 Item Categories** — Foods (burger, salad, ice cream), Beverages (hot/cold coffee in S/M/L), Merchandise (Bear, Tumblr, Robot)
- **Customer Emotion System** — Customers change emotion (happy → flat → angry) based on wait time
- **Stock Management** — Merchandise stock is limited; restock using in-game income
- **Score & High Score Tracking** — Score is calculated from remaining time, income, and customers served
- **Best Time Tracking** — Per-difficulty best and previous completion time
- **Persistent Save Data** — Player data saved to `PlayerData.dat` via binary serialization
- **Sound Effects & Music** — Separate volume controls for SFX and BGM (via Windows Media Player)
- **Settings Panel** — Pause menu with volume controls accessible mid-game

---

## 🗂️ Project Structure

```
Food-Wars/
├── Project/
│   ├── FormGame.cs           # Main game logic & UI
│   ├── FormGame.Designer.cs  # Auto-generated UI layout
│   ├── Players.cs            # Player class (name, score, income, history)
│   ├── PlayerSaveData.cs     # Serializable player data wrapper
│   ├── Items.cs              # Base item class
│   ├── Foods.cs              # Foods item with ingredient sequence
│   ├── Beverages.cs          # Beverages item (hot/cold, size)
│   ├── Merchandise.cs        # Merchandise item with stock management
│   ├── Customers.cs          # Customer class with emotion & order
│   ├── Time.cs               # Custom timer class
│   ├── IngredientsfoOds.cs   # Ingredient data for foods
│   ├── IngredientsBeverages.cs
│   └── Program.cs
├── sound/
│   ├── game.mp3
│   ├── play.mp3
│   ├── button.mp3
│   ├── click.mp3
│   ├── correct.mp3
│   ├── fail.mp3
│   ├── win.mp3
│   └── lose.mp3
└── README.md
```

---

## 🧮 Scoring Formula

```
Score = (Total Customers × 100) + (Remaining Seconds × Multiplier) + Income Earned
```

| Difficulty  | Customers | Time Limit | Multiplier |
|-------------|-----------|------------|------------|
| Easy        | 8         | 30s        | ×25        |
| Medium      | 15        | 40s        | ×50        |
| Hard        | 23        | 50s        | ×75        |
| Impossible  | 32        | 60s        | ×100       |

---

## 🛠️ Requirements

- Windows OS
- .NET Framework (WinForms)
- Windows Media Player library (`WMPLib`)
- Visual Studio (recommended)

---

## 🚀 How to Run

1. Clone or download this repository
2. Open `Project.sln` in Visual Studio
3. Build the solution (`Ctrl+Shift+B`)
4. Run with `F5` or click **Start**

> Make sure the `sound/` folder is in the same directory as the `.exe` after build.

---

## 👤 Author

**imyourchel** — Universitas Surabaya (UBAYA)
