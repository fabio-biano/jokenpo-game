# Introduction 
This is a didatic project, for study purposes.
It shows some design patterns and programming practices in a solution written in C# and .NET 7.
The solution consists in some projects to develop a Jokenpo Game.
The game has the following structure:

 - JokenpoGameSample.Api: The main web api project that access domain layer and processes the UI requests for the game.
 - JokenpoGameSample.Domain: Encapsulates all business logic and domain classes.
 - JokenpoGameSample.Mobile: The mobile game version designed with .NET MAUI.
 - JokenpoGameSample.UnityTests: The unity tests for api and domain logic.
 - JokenpoGameSample.Web: The web game versions designed with Angular.

The game is simple: Two players must select one of the folowing objects: Stone, Paper and Scissor. Each one is strong against one and weak against another

**Example:**

Stone

    Wins against Scissor
    Loses against Paper

Paper

    Wins against Stone
    Loses agains Scissor

Scissor

    Wins against Paper
    Loses against Stone

# Getting Started
The solution is simple. You just need to compile and run the Unity Tests to see it working.

# Build and Test
To build just right click on JokenpoGameSample solution and select *Build Solution*.

To test, just open the Test Explorer, right click on the desired tests and click Run.
```