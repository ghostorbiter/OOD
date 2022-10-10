# Space mission 

Two different space missions store their travel routes. To save a bit, they want to have two common algorithms.
There are 2 space missions. Each of them stores a travel route. There are 2 algorithms.
The task is to write such a code, that algorithms will be written only once and will work for any space mission.
Code must be extensible - adding any new mission shouldn't cause any changes in algorithms code.
Solution should be presented on the example of two algorithms.

## Space missions

### American Mission (AmericanMission)

Mission stores travel route in a linked list. 
A mission starts on space station, and the list stores next stops with distances to them from the rpevious stop.

### Chinese Mission (ChineseMission)

Mission stores travel route in a matrix of distances and a list of next stops. Indices in matrix of distances are the same as in Planet enum. 
A mission starts from the first planet on the list.

## Algorithms

### Total distance (TotalDistance)

Returns total distance of a route, together with planets names.

### Moving average (MovingAverage)

Returns moving average of distances for a given subset size. 

### Total value of moving average results

It should be possible to use together calculating MovingAverage and TotalDistance. Returned value is a sum of values calculated by MovingAverage.

**Required memory complexity for both algorithms - O(1)**

## What is allowed

Extending existing classes, adding new classes and interfaces, implementing algorithms.

## What is not allowed

Modifying existing properties and methods in given classes, adding different representations of collections stored in classes, using yield keyword.
