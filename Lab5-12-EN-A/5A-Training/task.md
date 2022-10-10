# Training

Your task is to implement several training programmes that a football managers sets for players in his team.
The players handle the tasks assigned to them in different ways (or not at all).
The manager determines what should be done, but does not know the specifics, as each part of the training is handled by his subordinates (i.e. these are separate components).

The solution consists of:
- The `Manager` class, representing the manager who sets the training programme for the players in his team
- The `Player` abstract class, along with concrete classes that extend it: `Superstar`, `SquadPlayer`, and `InjuryReturnee`,
- The main program, with a predefined group of players.

## Players

- ### Superstar
Is completely absent-minded, so has a 25% chance of doing something else than what the manager decided.

- ### SquadPlayer
Never goes on sick leave, but has a 33% chance of being away for optional training and not doing the task as a result.

- ### InjuryReturnee
Does not attend high intensity training.

## Manager's Tasks

- ### RegularSeason
Attend tactical briefing at 10:00, warm-up at 11:00, and high intensity training at 12:00. Repeat from 16:00 to 18:00.

- ### MatchDay
Tactical briefing at 11:00, warm-up at 12:00 and 20:00.

- ### OffSeason
50% chance of doing a warm-up at a random hour.

## Task
1. Finish the implementation of methods specific to the three classes for football players. Use predefined messages to print out console output wherever applicable.
2. Complete the implementation of the `Manager` class, and call its methods with appropriate parameter(s) as indicated in the main program.

## Notes
- You cannot extend or otherwise modify the players classes, except for finishing the implementation of their methods (see point 2 above).
- Once implemented, your solution should allow for new sets of tasks to be defined without any additional changes to `Manager`, `Player`, and its extensions.
- You can add new classes and interfaces.