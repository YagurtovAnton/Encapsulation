﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCeomrtey
{
	internal class EquilateralTriangle:IsoscalesTriangle
	{
		public EquilateralTriangle
		(double side, int startX, int startY, int lineWidth, Color color)
			: base(side, side, startX, startY, lineWidth, color) { }
	}
}
