using ConsoleApp2;
using System;

internal partial class Program
{
	private static void Main(string[] args)
	{
		var animals = new IAnimal[] { new Cat(), new Lion(), new Fish() };

		foreach (var animal in animals) 
		{
			animal.Feed();
			if (animal is Feline feline)
			{
				feline.MakeSound();
			}
		}

    }
}