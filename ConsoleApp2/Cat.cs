using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Cat : Feline
	{
		public override void Feed()
		{
            Console.WriteLine("Кота покормили");
        }

		public override void MakeSound()
		{
            Console.WriteLine("Мяу"); ;
		}
	}
}
