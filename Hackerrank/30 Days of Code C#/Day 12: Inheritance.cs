using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }

	public Person(string firstName, string lastName,int  id)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = id;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\n ID: " + id);
	}
}

class Student : Person
{

	private int[] testScores;

	public Student(string firstName, string lastName, int id, int[] scores)
	{
		this.firstName =firstName;
		this.lastName = lastName;
		this.id = id;
		this.testScores = scores;
	}

	public char Calculate()
	{
		var avr = testScores.Average();

		if (avr >= 90 && avr <= 100)
		{ return 'O'; }
		else if (avr >= 80 && avr < 90)
		{ return 'E'; }
		else if (avr >= 70 && avr < 80)
		{ return 'A'; }
		else if (avr >= 55 && avr < 70)
		{ return 'P'; }
		else if (avr >= 40 && avr < 55)
		{ return 'D'; }
		else if (avr < 40)
		{ return 'T'; }
		else
			return 'F';
	}
}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i] = Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
