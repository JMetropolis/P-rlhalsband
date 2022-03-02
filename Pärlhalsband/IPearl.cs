using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pärlhalsband
{
	public enum PearlColor {Black, White, Pink}
	public enum PearlShape {Round, Tear}
	public enum PearlType {Freshwater, Saltwater}

	internal interface IPearl
	{
		public int Size { get; set; }
		public PearlColor Color { get; set; }
		public PearlShape Shape { get; set; }
		public PearlType Type{ get; set; }
		public int PearlPrice { get; set; }

		void RandomInit();
	}
}
