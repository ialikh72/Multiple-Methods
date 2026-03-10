Basic Calculator in C#
Description

This C# program performs basic arithmetic operations on two numbers entered by the user.
The program demonstrates the use of methods (functions) in C# to perform different calculations such as addition, subtraction, multiplication, and division.

The program also includes a validation method to check whether division is possible when the second number is zero.

Features

Takes two integers as input from the user.

Performs the following operations:

Addition

Subtraction

Multiplication

Division

Uses separate methods for each operation.

Includes division validation to check if the divisor is zero.

Methods Used
Sum(int x, int y)

Adds two numbers and prints the result.

Sub(int x, int y)

Subtracts the second number from the first and prints the result.

Mul(int x, int y)

Multiplies two numbers and prints the result.

Div(int x, int y)

Divides the first number by the second number and prints the result.
Before division, it calls the validate() method.

validate(int a, int b)

Checks if the second number is zero.

If b == 0, division is not possible.

Otherwise, division can be performed.

Example Output
Concepts Used

C# Methods

Parameters

Console Input/Output

Conditional Statements (if-else)

Arithmetic Operators
