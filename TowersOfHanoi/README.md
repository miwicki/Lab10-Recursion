# Towers of Hanoi Console App

**Author**: Matt Iwicki <br />
**Version**: 1.0.0

## Overview
<b>Purpose:</b><br />
This app shows the use and value of recursion by solving the math problem called the Towers of Hanoi.

<b>Solutions:</b>
Given a starting number of disks n, and the mathematical equation behind the solution 2^n-1:
1. Recursion:
    1. if n is 1 then return 1
    2. return [2 * [call hanoi(n-1)] + 1]
2. Iteratively:
    1. 2^n - 1, for all n >= 1

## Necesarry Components
The following is required to run the program:
1. Visual Studio 2017 
2. The .NET desktop development workload enabled 

## Example 

```
Towers of Hanoi!
Enter a whole number to use as the starting number of disks:
4
Minimum number of moves
Using Recursion (Hanoi(n)): 15
Iteratively using for loop: 15
```

## Architecture
This application is created using ASP.NET Core 2.0 Console applicaitons. <br />
Language: C# <br />
