using Cosmos.Hardware;
using TylerOSBASIC.graphics;
using TylerOSBASIC.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerOSBASIC {
class GUI {

	public static Boolean guiLoaded;
	public static byte[] SBuffer = new byte[64000];
	public static VGAScreen screen = new VGAScreen();
	public static int backgroundColor = 7;

	public static void loadGUI() {
		screen.SetGraphicsMode(VGAScreen.ScreenSize.Size320x200, VGAScreen.ColorDepth.BitDepth8);
		screen.Clear(backgroundColor);
		guiLoaded = true;
		ConsoleModule.consoleLoaded = false;

		Taskbar.loadTaskbar();
		Taskbar.drawTaskbar();

		while (true) {
			MouseModule.loadMouse();
		}

		//shape(0, 0, 320, 1, 40); //top border
		//shape(0, 199, 320, 1, 40); //bottom border
		//shape(0, 0, 1, 200, 40); //left border
		//shape(319, 0, 1, 200, 40); //right border
	}

	public static void redraw() {
		screen.Clear(backgroundColor);
		Taskbar.drawTaskbar();
	}

	public static void pixel(uint x, uint y, uint c) {
		screen.SetPixel320x200x8(x, y, c);
	}

	public static void shape(uint x, uint y, uint width, uint height, uint c) {
		for (uint w = 0; w < width; w++) {
			for (uint h = 0; h < height; h++) {
				pixel(x + w, y + h, c);
			}
		}
	}
}
}