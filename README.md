# C# Squawk Code Generator

A transponder code, more commonly known as a "Squawk code" is a 4-digit number whose digits range from 0-7 whose purpose is to identify aircraft flying in an airspace. This program uses the .NET built-in pseudo-random number generator to generate these codes. ***THIS PROGRAM IS FOR SIMULATION USE ONLY!***

## Features

The program regenerates the code if it:
    Is equal to 7500, 7600, or 7700
    Has already beed generated in program runtime to avoid redundancy

The program allows the user to clear the list from inside the program using a `Console.ReadKey()` method and a case switch. The program also uses this case switch to allow the user to stop execution from inside the program.

## Prerequisites

This program requires the .NET 6.0 Runtime/SDK, as well as a computer capable of running .NET 6.0.

## Usage

1. Run `git clone https://github.com/ctech9/squawk-code-generator` and navigate to the root directory.

2. Open a terminal and run `dotnet run`.

## Licensing

This software is licensed under a GNU Affero GPL v3.0.

This means that you can:

    Sell this program
    Modify it
    Distribute it
    Use it for Patent Use
    Use it for Private use

As long as you:

    Add a copyright and licence notice
    State changes made
    Disclose the source (this repo)
    Use the same license (GNU Affero GPL v3.0)

This software comes with absolutely no liability or warranty.



This repository and all contents are Copyright © 2022 Christopher Thorpe.