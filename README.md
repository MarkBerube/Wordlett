# Wordlett

An ASP.NET multiplayer hangman game

## Installation

Clone this repository in GitHub or download the repository as a zip.

Upload the contents of the Wordlett directory (including the packages directory) to an IIS Express server that supports ASP.NET 4.5.

## Usage

View the application on the IIS Express server located in the `/Wordlett/` directory. 

You will be given a scrambled string of letters, and must de-scramble them into the correct word within a limited number of guesses.

The chances of getting the same word on multiple playthroughs is very slim as the words are randomly selected from a list of 58111 different dictionary words.