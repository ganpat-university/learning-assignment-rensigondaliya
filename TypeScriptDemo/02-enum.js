// Strongly typed variables
var myString;
myString = 'This is a string value';
var myString2 = 'This is another string value';
// Generates a compiler error because the variable cannot be assigned a 'number'
//myString = 4;
// Typescript can also infer the types
var anotherString = 'This is a string value'; // does not need the ":string" (by inferrence on assignment)
// Typescript can ONLY INFER on assignment during the declaration process.
var yetAnotherString;
yetAnotherString = 'This is a string value';
yetAnotherString = 5; // NO ERROR: 
// other basic type
var vString;
var vNumber;
var vBoolean;
var vArray; // generic type
var vObject;
