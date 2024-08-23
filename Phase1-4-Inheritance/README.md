# Packing Inventory (150 XP)

You know you have a long, dangerous journey ahead of you to travel to and repair the Fountain of Objects. To prepare for the trip, you decide to build some classes and objects to manage your inventory. You decide to create a `Pack` class to help hold your items. Each pack has three limits: the total number of items it can hold, the weight it can carry, and the volume it can hold. Each item has a weight and volume, and you must not overload a pack by adding too many items, too much weight, or too much volume.

There are many item types that you might add to your inventory, each their own class in the inventory system:

1. **Arrow**: Weight = 0.1, Volume = 0.05
2. **Bow**: Weight = 1, Volume = 4
3. **Rope**: Weight = 1, Volume = 1.5
4. **Water**: Weight = 2, Volume = 3
5. **Food rations**: Weight = 1, Volume = 0.5
6. **Sword**: Weight = 5, Volume = 3

## Objectives

- **InventoryItem Class**:
  - Create an `InventoryItem` class that represents any of the different item types. This class must represent the item’s weight and volume, which it needs at creation time (constructor).
  
- **Derived Classes**:
  - Create derived classes for each of the item types above. Each class should pass the correct weight and volume to the base class constructor but should be creatable with a parameterless constructor (e.g., `new Rope()` or `new Sword()`).
  
- **Pack Class**:
  - Build a `Pack` class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time and cannot change afterward.
  - Add a public `bool Add(InventoryItem item)` method to the `Pack` class that allows you to add items of any type to the pack’s contents. This method should fail (return `false` and not modify the pack’s fields) if adding the item would cause it to exceed the pack’s item, weight, or volume limit.
  
- **Pack Properties**:
  - Add properties to `Pack` that allow it to report the current item count, weight, and volume, as well as the limits of each.

- **Program Implementation**:
  - Create a program that creates a new pack and then allows the user to add (or attempt to add) items chosen from a menu.

---