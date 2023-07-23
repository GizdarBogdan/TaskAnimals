using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Fish : IAnimal
	{
		public void Feed()
		{
            Console.WriteLine("Рыбке дали корм"); ;
		}
	}
}
