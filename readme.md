 
## Table of Contents

1. [Installation Instructions](#id-section1)

2. [Capstone Requirements](#id-section2)

3. [General Information about the App](#id-section3)

4. [Miscellaneous](#id-section4)

  

<hr>

  

<div  id='id-section1'/>

  

### Installation Instructions

*The following are instructions, in accordance with the Code Louisville's Software Development [C#] Capstone Project requirements, on how to install this application.*

* *This application is developed with `.NET 6.0`. The `.txt` log file that logs each game's results are stored in your `Documents` folder.*

<hr>

  

<div  id='id-section2'/>

  

### Capstone Requirements

*The following is a detailed section indicating where project requirements are met in the repository & application.*

* Has at least **5** commits on GitHub. All commits have been made directly through **Visual Studio**. &radic;

* Has a **`readme.md`** file containing a paragraph+ describing the application, the capstone requirements met, & installation instructions. &radic;

* Has at least one class & at least one object of that class populated with data. Data must be used or displayed in the application. &radic;
`Line 13 & 14 in GameConsole.cs will have a Player & Opponent object created from the respective classes. Data from the Player object is used and displayed in the application.`

* Has at least 3 functions or methods with at least one returning a value that is used in the application. &radic;

* **Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program**

* **Create an additional class which inherits one or more properties from its parent**
`Player.cs & Opponent.cs inherit from Pegboard.cs with a Pegs property & a PlacePegs() method.`

* **Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program**

* **Implement a log that records errors, invalid inputs, or other important events and writes them to a text file**

* **Implement a regular expression (regex) to ensure a field either a phone number or an email address is always stored and displayed in the same format**
`RegEx contained in Player.cs to ensure player's input follows the same format.`

<hr>

<div  id='id-section3'/>

  

### General Information about the Application

This application is intended for general use & is a fun console-version of the Mastermind board game. Gameplay includes the computer rendering a row of 4 numbers between 0-4 on a "pegboard" and keeping said row of 4 numbers hidden from user's sight. The user must then submit guesses consisting of a row of 4 numbers between 0-4 in hopes that their guess contains each correct number in correct positioning. The computer will provide feedback for each number in the user's row of 4 numbers indicating whether the number is either *correct number in correct position*, *correct number in incorrect position*, or *incorrect number in incorrect position*. The user must use logic to instruct future guesses based on this feedback.

This application is programmed using **`C#`**. This application utilizes a number of *Collections* including arrays & lists and also utilizes *regular expressions* (RegEx).

  

>  **Room for Improvement**

>  * Need to print a message to user upon successfully completing a round of Mastermind detailing how many guesses the user took to guess the computer's code-row correctly. &radic;

>  * Need to store game history to an external file. &radic;

<hr>

<div  id='id-section4'/>

  

### Miscellaneous