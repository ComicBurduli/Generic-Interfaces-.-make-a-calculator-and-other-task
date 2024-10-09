# Generic-Interfaces-.-make-a-calculator-and-other-task


task 1
1. Create a generic class with two types
Parameter T and U
2. Set the T-type parameters as low as possible
Only value type;
3. Set the parameters of the U type to be limited
Reference type only;
4. T-type field and U-type property of classes;
5. Parameterized class constructor, which
Mifill values ​​and froferti;
6. Two-parameter method of classes, one group
One will be of T type and the other will be of U type, and the method
Makes the field and property available
overwriting values ​​with new values;
7. The class also has a second method that provides
to print the values ​​of class members;
8.program.cs Create an instance of this generic class where
For example: T will be of int type, and U will be of string type;
9. For the created object (instance), call its
function of the ring;
10. Then assign the class values
Using the value class method;
11. After assigning, reprint the class members
updated values;****


task 2 

Let's write a console application where we will have a Generic interface
IMathOperation, which will only accept struct types.
An interface should have three methods: add, subtract,
multiplication. (Each of them must take a Generic <T> as a parameter
types and must also return it), must be created on the interface
Two dependent classes, one for the int type (IntMathOperation),
For the second double type (DoubleMathOperation). Of course, both
A class will have methods on all three interfaces that it implements
We have to do it. From Main, each operation will create an object
Then the integers and decimals must be added correctly,
subtraction and multiplication.
