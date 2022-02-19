/*
fibonacci (1 1 2 3 5 8 13 21 34 55 89 144 )

- create a function that takes an integer values "start" and "length"
- function begins the fibonacci sequence at "start" and writes to console the next "length" amount of numbers in the sequence
- assume that you will not always be given a 'start' value in the fibonacci sequence, so you would continue the sequence with the next largest value in the sequence

*/
using System;

//test program
Console.Write("Input the number to start at: ");
int st = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of times to move through the sequence: ");
int len = Convert.ToInt32(Console.ReadLine());

//call fibonacci function
fibonacci(st, len);

Console.WriteLine("press enter to close");
Console.Read();


void fibonacci(int start, int length) 
{
	int current = 0, prev = 1, back = 0;

	//load variables until 'current' passes 'start'
	for (current = prev + back; current < start; current = prev + back){
		
		back = prev;
		prev = current;
	}

	//continue the sequence for 'length' more times
	for (int i=1; i <= length; i++){

		current = prev + back;
		Console.Write(current + " ");

		back = prev;
		prev = current;
	}
	Console.WriteLine();
}


