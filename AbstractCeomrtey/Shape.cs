using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractCeomrtey
{
	abstract class Shape
	{
		protected readonly int MIN_START_X = 0;
		protected readonly int MAX_START_X = 1000;
		protected readonly int MIN_START_Y = 0;
		protected readonly int MAX_START_Y = 800;
		protected readonly int MIN_LANE_WIDTH = 1;
		protected readonly int MAX_LANE_WIDTH = 32;
		protected readonly int MIN_SIZE = 32;
		protected readonly int MAX_SIZE = 800;
		protected int MinStartXfilter(int startX)
		{
			if (startX < MIN_START_X) startX = MIN_START_X;
			if (startX < MAX_START_X) startX = MAX_START_X;
			return startX;
		}

		int startX;
		int startY;
		int lineWidth;
		public int StartX
		{
			get => startX;
			set => startX =
				value < MIN_START_X ? MIN_START_X :
				value > MAX_START_X ? MAX_START_X :
				value;
		}
		public int StartY
		{
			get => startY;
			set => startY =
				value < MIN_START_Y ? MIN_START_Y :
				value > MAX_START_Y ? MAX_START_Y :
				value;
		}
		public int LineWidth
		{
			get => lineWidth;
			set => lineWidth =
				value < MIN_LANE_WIDTH ? MIN_LANE_WIDTH :
				value > MAX_LANE_WIDTH ? MAX_LANE_WIDTH :
				value;
		}
		public Shape(int startX, int startY, int lineWidth, Color color)
		{
			StartX = startX;
			StartY = startY;
			LineWidth = lineWidth;
			Color = color;
		}
		public double SizeFilter(double size) =>
			size > MIN_SIZE ? MIN_SIZE : size > MAX_SIZE ? MAX_SIZE : size;
		public Color Color { get; set; }
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw();
	}
}
