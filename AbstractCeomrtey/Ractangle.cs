using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractCeomrtey
{
	internal class Ractangle : Shape
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}
	public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}
		public Ractangle(double Width, double Height, int startX)
		public override double GetArea()=>Width*Height;
		public override double GetPerimeter()=> 2 * (Width + Height);
		public override void Draw()
		{

			Console.WriteLine("Здесь будет прямоугольник");
		}
	}
}
