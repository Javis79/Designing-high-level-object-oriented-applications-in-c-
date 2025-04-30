# Prisoner's Dilemma Simulator

This project is a console application written in C# created as part of an assignment to explore **game theory**, **object-oriented design**, and **strategy simulation**. The program models a multi-round **prisoner’s dilemma** tournament between various player strategies.

## Game Setup

- **Rounds per game:** 30  
- **Scoring rules:**
  - Both cooperate: **+10** each  
  - One betrays, the other cooperates: **+15** / **–10**  
  - Both betray: **0** each

The game runs all-versus-all matches between 5 player instances using different strategies.

---

## Class Overview

### `Player`
- Fields:
  - `StrategyName` – name of the strategy  
  - `PartnerMoves` – history of opponent moves  
  - `Score` – accumulated game score  
- Methods:
  - `GetNextMove()` – asks the strategy for the next decision

### `IStrategy`
Interface for all strategy implementations:
```csharp
bool GetNextMove(List<bool> knownMoves);
```
- `true` = cooperate  
- `false` = betray

---

## Implemented Strategies

### `StrategyCounter`
- Cooperates unless the opponent **betrayed in the last round**.
- First move is random (50/50).

### `StrategyForgiving`
- Like `Tit For Tat`, but **forgives a betrayal** if preceded by cooperation.
- First move is random.

### `StrategyGrudger`
- **Cooperates until betrayed once**, then always betrays.
- First move is random.

### `StrategyRandom`
- Randomly cooperates or betrays with **50% chance**.

### `StrategyRepeater`
- Repeats **opponent’s last move**.
- First move is random.

---

## Program Behavior

The simulation does the following:
- Creates players with different strategies.
- Runs all pairwise matchups (10 total games for 5 players).
- Each match runs 30 rounds.
- Scores are updated after every move.
- At the end, total points per strategy are printed.

---

## Sample Output

```
---Game 1---
Player4 score: 300
Player3 score: 90

---Game 2---
Player4 score: 520
Player2 score: 190

...

Results table:
---Counter---
Player0 score: 440
---Forgiving---
Player1 score: 380
---Grudger---
Player2 score: 190
---Random---
Player3 score: 90
---Repeater---
Player4 score: 620
```

---

## Author

Created by **Krystian Bajerski** as part of a university project in the course:  
**Designing and creating high-level object-oriented applications**
