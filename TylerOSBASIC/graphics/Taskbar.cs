﻿using Cosmos.Hardware;
using TylerOSBASIC.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerOSBASIC.graphics {

class Taskbar {

	public static Boolean taskbarHidden;
	public VGAScreen screen = GUI.screen;

	public static void loadTaskbar() {
		taskbarHidden = true;
	}

	public static void drawTaskbar() {
		if (taskbarHidden == true) {
			GUI.shape(0, 199, 320, 1, 56); // taskbar hidden
		} else if (taskbarHidden == false) {
			GUI.shape(0, 188, 320, 12, 56); // taskbar shown
			FontDrawer.WriteText(Cosmos.Hardware.RTC.Hour + ":" + Cosmos.Hardware.RTC.Minute, 300 - 9, 200 - 9, 0);
		}
	}
}
}