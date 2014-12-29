using Cosmos.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerOSBASIC.graphics {
public static class FontDrawer {
	#region textmaker

	//static VGAScreen screen = GUI.screen;

	public static void DrawTextChar(uint x, uint y, byte[] data, uint color) {
		int c = 0;
		for (uint p = y; p < y + 9; p++) {
			for (uint i = x; i < x + 5; i++) {
				if (data[c] == 1) {
					GUI.pixel(i, p, color);
				}

				c = c + 1;
			}
		}
	}

	public static void DrawArray(uint x, uint y, byte[] data, uint color, int w, int h) {
		int c = 0;
		for (uint p = y; p < y + w; p++) {
			for (uint i = x; i < x + h; i++) {
				if (data[c] == 1) {
					GUI.pixel(i, p, color);
				}

				c = c + 1;
			}
		}
	}

	public static void WriteText(String Text, uint textX, uint textY, uint color) {
		foreach (char a in Text) {
			if (a == 'A') {
				DrawTextChar(textX, textY, Font8x8.CapA, color);
				textX = textX + 6;
			} else if (a == 'a') {
				DrawTextChar(textX, textY, Font8x8.SmlA, color);
				textX = textX + 6;
			} else if (a == 'B') {
				DrawTextChar(textX, textY, Font8x8.CapB, color);
				textX = textX + 6;
			} else if (a == 'b') {
				DrawTextChar(textX, textY, Font8x8.SmlB, color);
				textX = textX + 6;
			} else if (a == 'C') {
				DrawTextChar(textX, textY, Font8x8.CapC, color);
				textX = textX + 6;
			} else if (a == 'c') {
				DrawTextChar(textX, textY, Font8x8.SmlC, color);
				textX = textX + 6;
			} else if (a == 'D') {
				DrawTextChar(textX, textY, Font8x8.CapD, color);
				textX = textX + 6;
			} else if (a == 'd') {
				DrawTextChar(textX, textY, Font8x8.SmlD, color);
				textX = textX + 6;
			} else if (a == 'E') {
				DrawTextChar(textX, textY, Font8x8.CapE, color);
				textX = textX + 6;
			} else if (a == 'e') {
				DrawTextChar(textX, textY, Font8x8.SmlE, color);
				textX = textX + 6;
			} else if (a == 'F') {
				DrawTextChar(textX, textY, Font8x8.CapF, color);
				textX = textX + 6;
			} else if (a == 'f') {
				DrawTextChar(textX, textY, Font8x8.SmlF, color);
				textX = textX + 6;
			} else if (a == 'G') {
				DrawTextChar(textX, textY, Font8x8.CapG, color);
				textX = textX + 6;
			} else if (a == 'g') {
				DrawTextChar(textX, textY, Font8x8.SmlG, color);
				textX = textX + 6;
			} else if (a == 'H') {
				DrawTextChar(textX, textY, Font8x8.CapH, color);
				textX = textX + 6;
			} else if (a == 'h') {
				DrawTextChar(textX, textY, Font8x8.SmlH, color);
				textX = textX + 6;
			} else if (a == 'I') {
				DrawTextChar(textX, textY, Font8x8.CapI, color);
				textX = textX + 6;
			} else if (a == 'i') {
				DrawTextChar(textX, textY, Font8x8.SmlI, color);
				textX = textX + 6;
			} else if (a == 'J') {
				DrawTextChar(textX, textY, Font8x8.CapJ, color);
				textX = textX + 6;
			} else if (a == 'j') {
				DrawTextChar(textX, textY, Font8x8.SmlJ, color);
				textX = textX + 6;
			} else if (a == 'K') {
				DrawTextChar(textX, textY, Font8x8.CapK, color);
				textX = textX + 6;
			} else if (a == 'k') {
				DrawTextChar(textX, textY, Font8x8.SmlK, color);
				textX = textX + 6;
			} else if (a == 'L') {
				DrawTextChar(textX, textY, Font8x8.CapL, color);
				textX = textX + 6;
			} else if (a == 'l') {
				DrawTextChar(textX, textY, Font8x8.SmlL, color);
				textX = textX + 6;
			} else if (a == 'M') {
				DrawTextChar(textX, textY, Font8x8.CapM, color);
				textX = textX + 6;
			} else if (a == 'm') {
				DrawTextChar(textX, textY, Font8x8.SmlM, color);
				textX = textX + 6;
			} else if (a == 'N') {
				DrawTextChar(textX, textY, Font8x8.CapN, color);
				textX = textX + 6;
			} else if (a == 'n') {
				DrawTextChar(textX, textY, Font8x8.SmlN, color);
				textX = textX + 6;
			} else if (a == 'O') {
				DrawTextChar(textX, textY, Font8x8.CapO, color);
				textX = textX + 6;
			} else if (a == 'o') {
				DrawTextChar(textX, textY, Font8x8.SmlO, color);
				textX = textX + 6;
			} else if (a == 'P') {
				DrawTextChar(textX, textY, Font8x8.CapP, color);
				textX = textX + 6;
			} else if (a == 'p') {
				DrawTextChar(textX, textY, Font8x8.SmlP, color);
				textX = textX + 6;
			} else if (a == 'Q') {
				DrawTextChar(textX, textY, Font8x8.CapQ, color);
				textX = textX + 6;
			} else if (a == 'q') {
				DrawTextChar(textX, textY, Font8x8.SmlQ, color);
				textX = textX + 6;
			} else if (a == 'R') {
				DrawTextChar(textX, textY, Font8x8.CapR, color);
				textX = textX + 6;
			} else if (a == 'r') {
				DrawTextChar(textX, textY, Font8x8.SmlR, color);
				textX = textX + 6;
			} else if (a == 'S') {
				DrawTextChar(textX, textY, Font8x8.CapS, color);
				textX = textX + 6;
			} else if (a == 's') {
				DrawTextChar(textX, textY, Font8x8.SmlS, color);
				textX = textX + 6;
			} else if (a == 'T') {
				DrawTextChar(textX, textY, Font8x8.CapT, color);
				textX = textX + 6;
			} else if (a == 't') {
				DrawTextChar(textX, textY, Font8x8.SmlT, color);
				textX = textX + 6;
			} else if (a == 'U') {
				DrawTextChar(textX, textY, Font8x8.CapU, color);
				textX = textX + 6;
			} else if (a == 'u') {
				DrawTextChar(textX, textY, Font8x8.SmlU, color);
				textX = textX + 6;
			} else if (a == 'V') {
				DrawTextChar(textX, textY, Font8x8.CapV, color);
				textX = textX + 6;
			} else if (a == 'v') {
				DrawTextChar(textX, textY, Font8x8.SmlV, color);
				textX = textX + 6;
			} else if (a == 'W') {
				DrawTextChar(textX, textY, Font8x8.CapW, color);
				textX = textX + 6;
			} else if (a == 'w') {
				DrawTextChar(textX, textY, Font8x8.SmlW, color);
				textX = textX + 6;
			} else if (a == 'X') {
				DrawTextChar(textX, textY, Font8x8.CapX, color);
				textX = textX + 6;
			} else if (a == 'x') {
				DrawTextChar(textX, textY, Font8x8.SmlX, color);
				textX = textX + 6;
			} else if (a == 'Y') {
				DrawTextChar(textX, textY, Font8x8.CapY, color);
				textX = textX + 6;
			} else if (a == 'y') {
				DrawTextChar(textX, textY, Font8x8.SmlY, color);
				textX = textX + 6;
			} else if (a == 'Z') {
				DrawTextChar(textX, textY, Font8x8.CapZ, color);
				textX = textX + 6;
			} else if (a == 'z') {
				DrawTextChar(textX, textY, Font8x8.SmlZ, color);
				textX = textX + 6;
			} else if (a == '.') {
				DrawTextChar(textX, textY, Font8x8.Dote, color);
				textX = textX + 6;
			} else if (a == '!') {
				DrawTextChar(textX, textY, Font8x8.Utro, color);
				textX = textX + 6;
			} else if (a == ' ') {
				DrawTextChar(textX, textY, Font8x8.Null, color);
				textX = textX + 6;
			} else if (a == '0') {
				DrawTextChar(textX, textY, Font8x8.Zero, color);
				textX = textX + 6;
			} else if (a == '1') {
				DrawTextChar(textX, textY, Font8x8.One, color);
				textX = textX + 6;
			} else if (a == '2') {
				DrawTextChar(textX, textY, Font8x8.Two, color);
				textX = textX + 6;
			} else if (a == '3') {
				DrawTextChar(textX, textY, Font8x8.Three, color);
				textX = textX + 6;
			} else if (a == '4') {
				DrawTextChar(textX, textY, Font8x8.Four, color);
				textX = textX + 6;
			} else if (a == '5') {
				DrawTextChar(textX, textY, Font8x8.Five, color);
				textX = textX + 6;
			} else if (a == '6') {
				DrawTextChar(textX, textY, Font8x8.Six, color);
				textX = textX + 6;
			} else if (a == '7') {
				DrawTextChar(textX, textY, Font8x8.Seven, color);
				textX = textX + 6;
			} else if (a == '8') {
				DrawTextChar(textX, textY, Font8x8.Eight, color);
				textX = textX + 6;
			} else if (a == '9') {
				DrawTextChar(textX, textY, Font8x8.Nine, color);
				textX = textX + 6;
			} else if (a == ':') {
				DrawTextChar(textX, textY, Font8x8.Colon, color);
				textX = textX + 6;
			}
		}
	}

	#endregion

}
}
