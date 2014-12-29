using Cosmos.Hardware;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace TylerOSBASIC {

public class Kernel : Sys.Kernel {

	protected override void BeforeRun() {
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Operating system by Tyler Olson built on Cosmos Kernel v1.0.0");
		Console.ForegroundColor = ConsoleColor.White;
	}

	protected override void Run() {
		Boolean isConsole = true;

		if (isConsole == true) {
			ConsoleModule.loadConsole();
		} else if (isConsole == false) {
			GUI.loadGUI();
		}
	}
}
}