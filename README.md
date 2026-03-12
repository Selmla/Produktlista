# Produktlista – C# Console Application

A simple C# console application that collects product numbers from the user, validates them, and prints a sorted list.

## Assignment

The program asks the user to enter product numbers until the user types `exit`.

Valid product numbers follow the format:

TEXT-NUMBER

Example:

```
CE-400
XX-480
LABAN-231
```

Rules:

* The left part must contain **letters only**
* The right part must be a **number between 200 and 500**
* The input format must be **TEXT-NUMBER**

Invalid examples:

```
CE400
XX3-480
LABAN-100
```

## How to run the program

Clone the repository and run:

```
dotnet run
```

Then enter product numbers in the console.

Type:

```
exit
```

to finish and display the sorted product list.

## What the program does

* Reads user input
* Validates the format of product numbers
* Stores valid products in a list
* Sorts the list alphabetically
* Prints the sorted result

## 🛠 Technologies

* C#
* .NET Console Application
