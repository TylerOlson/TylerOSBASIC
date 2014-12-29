using Cosmos.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TylerOSBASIC {

class ConsoleModule {

	public static Boolean consoleLoaded;
	public static string[] commands = new string[] { "commands", "color", "ram", "gui", "shutdown", "quit", "exit", "restart", "reboot", "time", "date", "cls" };

	public static void loadConsole() {
		Console.Write("> ");
		consoleLoaded = true;
		GUI.guiLoaded = false;
		var input = Console.ReadLine();

		ConsoleColor tempConsoleColor = Console.ForegroundColor;

		if (input == commands[0].ToLower()) {
			Console.WriteLine("COMMANDS:");
			for (int i = 0; i < commands.Length; i++) {
				Console.Write(commands[i] + " ");
				Console.WriteLine("");
			}
			return;
		} else if (input == commands[1].ToLower()) {
			Console.WriteLine("ERROR: Invaild use.");
			Console.WriteLine("EXAMPLE: color red");
			Console.WriteLine("Valid colors:");
			Console.WriteLine("Black");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Blue");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Cyan");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("DarkBlue");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("DarkCyan");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("DarkGray");
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("DarkGreen");
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("DarkMagenta");
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("DarkRed");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("DarkYellow");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Gray");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Green");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Magenta");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Red");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("White");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Yellow");
			Console.ForegroundColor = tempConsoleColor;
			return;
		} else if (input == commands[1] + " black".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Black) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Black;
			}
			return;
		} else if (input == commands[1] + " blue".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Blue) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Blue;
			}
			return;
		} else if (input == commands[1] + " cyan".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Cyan) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Cyan;
			}
			return;
		} else if (input == commands[1] + " darkblue".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkBlue) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkBlue;
			}
			return;
		} else if (input == commands[1] + " darkcyan".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkCyan) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkCyan;
			}
			return;
		} else if (input == commands[1] + " darkgray".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkGray) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkGray;
			}
			return;
		} else if (input == commands[1] + " darkgreen".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkGreen) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkGreen;
			}
			return;
		} else if (input == commands[1] + " darkmagenta".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkMagenta) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
			}
			return;
		} else if (input == commands[1] + " darkred".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkRed) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkRed;
			}
			return;
		} else if (input == commands[1] + " darkyellow".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.DarkYellow) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.DarkYellow;
			}
			return;
		} else if (input == commands[1] + " gray".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Gray) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			return;
		} else if (input == commands[1] + " green".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Green) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Green;
			}
			return;
		} else if (input == commands[1] + " magenta".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Magenta) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Magenta;
			}
			return;
		} else if (input == commands[1] + " red".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Red) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Red;
			}
			return;
		} else if (input == commands[1] + " white".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.White) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
				Console.ForegroundColor = ConsoleColor.White;
			}
			return;
		} else if (input == commands[1] + " yellow".ToLower()) {
			if (Console.ForegroundColor == ConsoleColor.Yellow) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERROR: The foreground is already that color");
				Console.ForegroundColor = tempConsoleColor;
			} else {
				Console.ForegroundColor = ConsoleColor.Yellow;
			}
			return;
		} else if (input == commands[2]) {
			Console.WriteLine("RAM:" + Cosmos.Core.CPU.GetAmountOfRAM());
			return;
		} else if (input == commands[3]) {
			GUI.loadGUI();
			return;
		} else if ((input == commands[4]) || (input == commands[5]) || (input == commands[6])) {
			ACPI.Shutdown();
			ACPI.Disable();
			Cosmos.Core.Global.CPU.Halt();
			return;
		} else if ((input == commands[7]) || (input == commands[8])) {
			ACPI.Reboot();
			return;
		} else if (input == commands[9]) {
			Console.WriteLine(Cosmos.Hardware.RTC.Hour + ":" + Cosmos.Hardware.RTC.Minute + ":" + Cosmos.Hardware.RTC.Second);
			return;
		} else if (input == commands[10]) {
			Console.WriteLine(Cosmos.Hardware.RTC.Month + "-" + Cosmos.Hardware.RTC.DayOfTheMonth + "-" + Cosmos.Hardware.RTC.Year);
			return;
		} else if (input == commands[11]) {
			Console.Clear();
			return;
		} else {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("ERROR: Command not found, type commands for vaild list");
			Console.ForegroundColor = tempConsoleColor;
			return;
		}
	}
}
}