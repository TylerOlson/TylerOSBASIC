using Cosmos.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TylerOSBASIC.graphics;

namespace TylerOSBASIC.input {

class MouseModule {

	public static Mouse mouse = new Mouse();
	public static string buttonPressed;
	public static uint backgroundColor = (uint) GUI.backgroundColor;
	public static uint mouseColor = 10;
	public static uint oldx, oldy;

	static VGAScreen screen = GUI.screen;

	public static void loadMouse() {
		mouse.Initialize(320, 200);
		while (true) {
			update();
			handleButtonClicks();
		}
	}

	public static void handleButtonClicks() {
		if (mouse.Buttons == Mouse.MouseState.Left) {
			buttonPressed = "left";
		} else if (mouse.Buttons == Mouse.MouseState.Middle) {
			buttonPressed = "middle";
		} else if (mouse.Buttons == Mouse.MouseState.None) {
			buttonPressed = "none";
		} else if (mouse.Buttons == Mouse.MouseState.Right) {
			buttonPressed = "right";
		}
	}

	public static void update() {
		//while (true) {
		uint curX = (uint)mouse.X;
		uint curY = (uint)mouse.Y;

		if (curY == 199 && Taskbar.taskbarHidden == true) {
			Taskbar.taskbarHidden = false;
		}

		if(curY < 189 && Taskbar.taskbarHidden == false) {
			Taskbar.taskbarHidden = true;
		}

		if (curX != oldx || curY != oldy) {
			eraseMouse();
		}

		drawMouse(curX, curY);
		//}
	}

	public static void drawMouse(uint x, uint y) {
		GUI.pixel(x, y, mouseColor);
		GUI.pixel(x + 1, y, mouseColor);
		GUI.pixel(x + 2, y, mouseColor);
		GUI.pixel(x, y + 1, mouseColor);
		GUI.pixel(x, y + 2, mouseColor);
		GUI.pixel(x + 1, y + 1, mouseColor);
		GUI.pixel(x + 2, y + 2, mouseColor);
		GUI.pixel(x + 3, y + 3, mouseColor);

		oldx = x;
		oldy = y;
	}

	public static void eraseMouse() {
		GUI.pixel(oldx, oldy, backgroundColor);
		GUI.pixel(oldx + 1, oldy, backgroundColor);
		GUI.pixel(oldx + 2, oldy, backgroundColor);
		GUI.pixel(oldx, oldy + 1, backgroundColor);
		GUI.pixel(oldx, oldy + 2, backgroundColor);
		GUI.pixel(oldx + 1, oldy + 1, backgroundColor);
		GUI.pixel(oldx + 2, oldy + 2, backgroundColor);
		GUI.pixel(oldx + 3, oldy + 3, backgroundColor);

		GUI.redraw();
	}
}
}