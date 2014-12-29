using Cosmos.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerOSBASIC.input {

class KeyboardModule {

	public static Keyboard keyboard = new Keyboard();

	public static void getKeys() {
		var key = Console.ReadKey(false);

		if (key.Key == ConsoleKey.Escape && ConsoleModule.consoleLoaded == false) {
			ConsoleModule.loadConsole();
		}

	}

}
}