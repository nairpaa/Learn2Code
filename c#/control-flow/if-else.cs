using System;

/****************************************************
 
    if (condition) 
    {
        // do something
    }
    else if (condition2)
    {
        // do something else
    }
    else {
        // catch all
    }

*****************************************************/

var condition1 = true;
var condition2 = false;
var condition3 = false;

if (condition1 || condition2 && condition3)
    Console.WriteLine("1. Good to go");
    
if ((condition1 || condition2) && condition3)
    Console.WriteLine("2. Good to go");