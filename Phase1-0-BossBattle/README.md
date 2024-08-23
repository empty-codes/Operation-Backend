## Boss Battle: Hunting the Manticore (250 XP)

**Scenario:**
The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your programming skills will you have a chance to win this fight.

**Objective:**
Build a program that allows two users to participate:
- **Player 1 (Pilot of the Manticore):** Sets the airship’s range from the city (0 to 100).
- **Player 2 (City’s Defenses):** Attempts to find and destroy the airship by guessing the correct range.

The game continues until either the Manticore or the city is destroyed.

### Game Details

1. **Starting State:**
   - Manticore: 10 health points.
   - City: 15 health points.
   - Round: 1.

2. **Game Flow:**
   - **Player 1:** Secretly chooses how far the Manticore is from the city (0 to 100). The screen is cleared afterward.
   - **Player 2:** Tries to destroy the Manticore by guessing the range.
     - For each attempt, Player 2 is informed if they overshot (too far), fell short (not far enough), or hit the Manticore.
     - The damage dealt to the Manticore depends on the turn number:
       - **1 point**: If the turn number is not a multiple of 3 or 5.
       - **3 points**: If the turn number is a multiple of 3 or 5 (but not both).
       - **10 points**: If the turn number is a multiple of both 3 and 5.
   - If the Manticore is hit, its health is reduced by the expected amount. If the Manticore survives, the city takes 1 point of damage.

3. **End Game:**
   - The game ends when either the Manticore’s or the city’s health reaches 0. The outcome is displayed.

4. **Status Display:**
   - Before each round, display:
     - Round number
     - City’s health
     - Manticore’s health
     - Expected damage from the cannon.

5. **User Interface:**
   - Use different colors for different types of messages.

### Sample Run

```
Player 1, how far away from the city do you want to station the Manticore? 32
```

At this point, the display is cleared, and Player 2 gets their chance:

```
Player 2, it is your turn.
-----------------------------------------------------------
STATUS: Round: 1 City: 15/15 Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
-----------------------------------------------------------
STATUS: Round: 2 City: 14/15 Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 25
That round FELL SHORT of the target.
-----------------------------------------------------------
STATUS: Round: 3 City: 13/15 Manticore: 10/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 4 City: 12/15 Manticore: 7/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 5 City: 11/15 Manticore: 6/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 6 City: 10/15 Manticore: 3/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
```

The Manticore has been destroyed! The city of Consolas has been saved!

---

### Key Points:

- **Establish the game’s starting state:** Manticore starts with 10 health points, city with 15, and the game at round 1.
- **Player 1 sets the Manticore’s distance from the city (0 to 100).**
- **Loop the game** until either the Manticore’s or city’s health reaches 0.
- **Display the round status** before each turn.
- **Compute cannon damage** based on the round number.
- **Resolve the effect** of Player 2’s guess.
- **End the game** and display the outcome when the Manticore or city’s health reaches 0.
- **Use different colors** for messages.
- **Focus on solving one problem at a time using methods.**
- **Future Version:** Modify to allow the computer to randomly place the Manticore for a single-player game.