using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerOSBASIC.graphics {

class DrawLetter {

	public static void drawA(uint x, uint y, uint color) {
		GUI.pixel(x, y, color); // First row left
		GUI.pixel(x + 1, y, color); // First row right

		GUI.pixel(x - 1, y + 1, color); // Second row left
		GUI.pixel(x + 2, y + 1, color); // Second row right

		GUI.pixel(x - 1, y + 2, color); // Third row left
		GUI.pixel(x + 2, y + 2, color); // Third row right

		GUI.shape(x - 2, y + 3, 6, 1, color); // Fourth row

		GUI.pixel(x - 2, y + 4, color); // Fifth row left
		GUI.pixel(x + 3, y + 4, color); // Fifth row right

		GUI.pixel(x - 2, y + 5, color); // Sixth row left
		GUI.pixel(x + 3, y + 5, color); // Sixth row right

		GUI.pixel(x - 2, y + 6, color); // Seventh row left
		GUI.pixel(x + 3, y + 6, color); // Seventh row right
	}
}
}