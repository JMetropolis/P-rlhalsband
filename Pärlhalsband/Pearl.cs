using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pärlhalsband
{
	internal class Pearl : IPearl
	{
		public int Size { get; set; }
		public PearlColor Color { get; set; }
		public PearlShape Shape { get; set; }
		public PearlType Type { get; set; }

		public void RandomInit()
		{
			var rnd = new Random();
			Size = rnd.Next(5,25);
			Color = (PearlColor)rnd.Next((int)PearlColor.Black, (int)PearlColor.Pink);
			Shape = (PearlShape)rnd.Next((int)PearlShape.Round, (int)PearlShape.Tear);
			Type = (PearlType)rnd.Next((int)PearlType.Freshwater, (int)PearlType.Saltwater);

		}
		public Pearl()
		{
			RandomInit();
		}

		public override string ToString()
		{
			return $"{Size}mm\n{Color}\n{Shape}\n{Type}";
		}
	}
}
