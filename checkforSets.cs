using System;
using System.Collections.Generic;

// Create an function that can check if sets of parentheses are valid (matched)
// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// I used {} and () but could also have added <>, [], "", etc

public class Program
{
	public static void Main(){
		string[] tests = {
			"(1{hello}blah)",			//valid
			"{({(})})",					//not valid
			"((}}",						//not valid
			"{(({}))}",					//valid
			"{{BadString()}",			//not valid
			"{{GoodString(sat);}\t}"	//valid
		};

		foreach (string test in tests)
		{
			string answer;
			answer = checkforSets(test) ? "valid" : "not valid";
			Console.WriteLine($"'{test}' is {answer}.");
		}
		Console.Read();
	}

	static bool checkforSets(string given)
	{
		Stack<char> tracker = new Stack<char>();

		foreach(char thing in given){
			switch (thing)
			{
				case '(':
				case '{':
					tracker.Push(thing);
					break;
				case ')':
					if (tracker.Count == 0 || tracker.Pop() != '('){
						return false;
					}
					break;
				case '}':
					if (tracker.Count == 0 || tracker.Pop() != '{'){
						return false;
					}
					break;
				default:
					break;
			}
		}
		if(tracker.Count == 0) return true;
		else return false;
	}
}