# THE FIVE PROTOTYPES

## Narrative: Entering the Catacombs
You arrive at the Catacombs of the Class, the place that will reveal the path to the Fountain of Objects. The Catacombs lie inside a mountain, with a wide stone entrance leading you into a series of three chambers. In the first chamber, you find five pedestals with the remnants of a class definition and specific instructions by each. Etched above a sealed doorway at the back of the room is the text, “Only the True Programmer who can remake the Five Prototypes can proceed.” Each pedestal appears to have instructions for crafting a class. These are the Five Prototypes that you must reassemble.

---

## Boss Battle: The Point (75 XP)

**Objective:**

- Define a new `Point` class with properties for `X` and `Y`.
- Add a constructor to create a point from a specific `x`- and `y`-coordinate.
- Add a parameterless constructor to create a point at the origin `(0, 0)`.
- In your main method, create a point at `(2, 3)` and another at `(-4, 0)`. Display these points on the console window in the format `(x, y)` to illustrate that the class works.
- Answer this question: Are your `X` and `Y` properties immutable? Why did you choose what you did?

---

## Boss Battle: The Color (100 XP)

**Objective:**

- Define a new `Color` class with properties for its red, green, and blue channels.
- Add appropriate constructors that you feel make sense for creating new `Color` objects.
- Create static properties to define the eight commonly used colors for easy access.
- In your main method, make two `Color`-typed variables. Use a constructor to create a color instance and use a static property for the other. Display each of their red, green, and blue channel values.

---

## Boss Battle: The Card (100 XP)

**Objective:**

- Define enumerations for card colors and card ranks.
- Define a `Card` class to represent a card with a color and a rank, as described above.
- Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a face card).
- Create a main method that will create a card instance for the whole deck (every color with every rank) and display each (for example, “The Red Ampersand” and “The Blue Seven”).
- Answer this question: Why do you think we used a color enumeration here but made a color class in the previous challenge?

---

## Boss Battle: The Locked Door (100 XP)

**Objective:**

- Define a `Door` class that can keep track of whether it is locked, open, or closed.
- Make it so you can perform the four transitions defined above with methods.
- Build a constructor that requires the starting numeric passcode.
- Build a method that will allow you to change the passcode for an existing door by supplying the current passcode and new passcode. Only change the passcode if the current passcode is correct.
- Make your main method ask the user for a starting passcode, then create a new `Door` instance. Allow the user to attempt the four transitions described above (open, close, lock, unlock) and change the code by typing in text commands.

---

## Boss Battle: The Password Validator (100 XP)

**Objective:**

- Define a new `PasswordValidator` class that can be given a password and determine if the password follows the rules above.
- Make your main method loop forever, asking for a password and reporting whether the password is allowed using an instance of the `PasswordValidator` class.

---