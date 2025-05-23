# Observer Pattern Project

## Overview
This example demonstrates the **Observer Pattern** in Java using a wilderness setting. The `NightInTheWilderness` class acts as the **subject**, while various observer classes implement the `OnWatch` interface to monitor changes in the encounter state.

## Design Pattern: Observer
The Observer Pattern allows objects (observers) to listen for changes in another object (subject) and respond accordingly. It promotes **loose coupling** between components, making systems more maintainable.

## Class Structure
Here’s a breakdown of the primary classes in this example:

### `NightInTheWilderness`
- Class that implements LongRest interface and sets subscription, unsubscrption, and notification to changes.

### `LongRest`
- This interface acts as the subject in the observer pattern notifying observers depending on if the observers are awake (on watch) or asleep.

### `OnWatch` (Observer Interface)
- This interface is the observer which is notified when something happens.The method is technically getting notified when something happens.
  
### `Encounter` (Enum)
- Represents different wilderness events (e.g., **Nothing**, **Troll**, **Dragon**).
- Used to determine what the observers react to.

### Observer Implementations (`Ranger`, `Wizard`, etc.)
- These are implementations of subscribers to determine the response depending on whether the character is sleeping or something is happening.
