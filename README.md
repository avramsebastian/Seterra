# SETERRA - Educational Geography Game

## Description
SETERRA is an interactive educational tool designed to help users test and improve their geography knowledge in a fun and engaging way. Users can explore geographic maps and learn the names of countries, capitals, cities, and other geographical aspects. Specifically, this game focuses on the map of Romania, allowing players to identify correct cities and consolidate important geographical information in an interactive and enjoyable environment. The application is a Console App with a simplistic, intuitive, and easy-to-understand design, utilizing a color palette to attract the user.

## Motivation
SETERRA is one of the first games developed using Microsoft Visual Studio. The project was driven by several goals:
* Despite its apparent simplicity, the game can challenge any user due to the limited time allocated to complete the map.
* C# was chosen as the programming language due to its suitability for structuring the game's algorithms. 
* A passion for geography and a passion for games were also key motivations. 

## Technologies Used
* **Programming Language:** C# 
* **Development Environment:** Microsoft Visual Studio 2022 
* **Framework:** .Net Framework 3.5 

Microsoft Visual Studio provides a comprehensive set of development tools for creating ASP.NET applications, XML Web Services, desktop applications, and mobile applications, facilitating the creation of multi-language solutions.

## How to Run/Install
To run the application, you will need:
* .Net Framework 3.5 pack. 
* The game can be opened using the executable file "testdrive1.exe".

To edit the code, you will need:
* Microsoft Visual Studio 2019 or a more recent version. 
* Any version of Windows 10 or Windows Server 2016 (or more recent).

### Main Menu: 
The start screen contains the main menu with the following options:
* **Joacă (Play):** Starts a new game.
* **Învață (Learn):** Accesses the learning menu where you can learn or review cities before playing.
* **Ieși (Exit):** Closes the program. 

### Game Play:

1.  **Difficulty Selection:** Accessing the "Joacă" button will direct the user to the difficulty selection menu. 
    * **Ușor (Easy):** 2 minutes to complete the map. 
    * **Mediu (Medium):** 4 minutes to complete the map. 
    * **Dificil (Difficult):** 6 minutes to complete the map. 

2.  **Starting the Game:** After selecting the difficulty, the user is directed to the game menu. Initially, the map, a "Start" button, and a timer showing the remaining time are visible. Pressing the "Start" button begins the game.

3.  **Gameplay Mechanics:**
    * Buttons for each city will appear, to be completed by right-clicking.
    * A random city to be identified by the user will be generated below the timer.
    * The player's score will be displayed, and the timer will start counting down.
    * Players have 3 attempts to guess the city.
    * **Scoring and Feedback:**
        * If guessed on the first attempt, the button turns green, and the score increases by 1. 
        * If guessed on the second attempt, the button turns yellow. 
        * If guessed on the third attempt, the button turns red, and a new city is generated. 
        * If the player does not find the city within 3 attempts, the button automatically turns red to show the correct location, and a new city is generated.

4.  **Game End:** The game ends when all cities are completed or when time runs out. 
    * If time expires, a message will appear notifying the player, and all uncompleted cities will be colored red.
    * A "Joacă din nou" (Play Again) button will appear below the "Start" button, redirecting the user to the main menu.

### Learning Menu:
* Accessed via the "Învață" button.
* Players can practice identifying cities. Clicking on a city will make its name visible for 3 seconds.
* Alternatively, selecting the checkbox "Afișează toate" (Show all) will display all city names.
* Once ready, the player can press the "Sunt pregătit" (I'm ready) button to return to the main menu.

## Future Development
The following enhancements are planned for future versions: 
* **Cross-platform Development:** Expand the software to other devices, especially mobile phones, to reach a wider audience (students, teachers).
* **Player Progress Tracking:** Add a graph to display the player's progress or regression.
* **Expanded Geography Content:** Develop infinite possibilities within the field of geography, including:
    * Game modes for relief, climate, hydrography, or fauna, not just cities.
    * Include maps for all European countries and potentially other continents.

## Bibliography
1.  Microsoft – Programarea orientata pe obiecte si programarea vizuala .Net Framework 
2.  Constantin Galatan - C# pentru liceu ,editura L&S Info-mat 
3.  https://msdn.microsoft.com/en-us/library/kx37x362.aspx 
