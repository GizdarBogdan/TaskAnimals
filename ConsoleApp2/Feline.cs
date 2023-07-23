using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal abstract class Feline : IAnimal
	{
		public abstract void Feed();

		public abstract void MakeSound();
	}
}
