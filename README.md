# 2223-sd-classwork-unit-test-exercise

## Complete the give tasks bellow and follow the github workflows for test feedback

### Create a simple class Calculator that has methods for addition, subtraction, multiplication, and division in the Classwork-UnitTest project.
The methods should be named "Addition" for addition, "Subtraction" for subtraction, "Multiplication" for multiplication
and "Division" for division. Each method shoud take two whole numbers and return their result after the given opperation.
In the event of a division by zero the method "Division" should throw a DivideByZeroException("Cannot divide by zero").

### Create a class that validates user input called UserValidation. The class should have a method named EncryptPassword that accepts a string password as an argument.
The method should take each symbol of the password and alter it to one possition over in the ASCII code table. If the encryption method reaches a non-latin character it
returns to the begining of that given character group. As an example: 
```
Input: password
Output: qbttxpse
```
The method should return the encrypted password.

### Create a Interface Vehicle with abstract methods for driving, stopping and refueling named "Driving", "Stopping", "Refueling".
After you create the interface create a class Car with methods returning: 
```
Method Driving => "The car is driving"
Method Stopping => "The car is stopping"
Method Refueling => "The car is refueling"
```
Do the same for another class called Bicycle, but when you call the method refueling, return "This is a bike, it doesn't refuel"