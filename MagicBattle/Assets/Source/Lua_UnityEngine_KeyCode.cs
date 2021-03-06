﻿using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001701 RID: 5889
[Preserve]
public class Lua_UnityEngine_KeyCode : LuaObject
{
	// Token: 0x06023449 RID: 144457 RVA: 0x00C3DDBC File Offset: 0x00C3BFBC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.KeyCode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 8, "Backspace");
		LuaObject.addMember(l, 9, "Tab");
		LuaObject.addMember(l, 12, "Clear");
		LuaObject.addMember(l, 13, "Return");
		LuaObject.addMember(l, 19, "Pause");
		LuaObject.addMember(l, 27, "Escape");
		LuaObject.addMember(l, 32, "Space");
		LuaObject.addMember(l, 33, "Exclaim");
		LuaObject.addMember(l, 34, "DoubleQuote");
		LuaObject.addMember(l, 35, "Hash");
		LuaObject.addMember(l, 36, "Dollar");
		LuaObject.addMember(l, 38, "Ampersand");
		LuaObject.addMember(l, 39, "Quote");
		LuaObject.addMember(l, 40, "LeftParen");
		LuaObject.addMember(l, 41, "RightParen");
		LuaObject.addMember(l, 42, "Asterisk");
		LuaObject.addMember(l, 43, "Plus");
		LuaObject.addMember(l, 44, "Comma");
		LuaObject.addMember(l, 45, "Minus");
		LuaObject.addMember(l, 46, "Period");
		LuaObject.addMember(l, 47, "Slash");
		LuaObject.addMember(l, 48, "Alpha0");
		LuaObject.addMember(l, 49, "Alpha1");
		LuaObject.addMember(l, 50, "Alpha2");
		LuaObject.addMember(l, 51, "Alpha3");
		LuaObject.addMember(l, 52, "Alpha4");
		LuaObject.addMember(l, 53, "Alpha5");
		LuaObject.addMember(l, 54, "Alpha6");
		LuaObject.addMember(l, 55, "Alpha7");
		LuaObject.addMember(l, 56, "Alpha8");
		LuaObject.addMember(l, 57, "Alpha9");
		LuaObject.addMember(l, 58, "Colon");
		LuaObject.addMember(l, 59, "Semicolon");
		LuaObject.addMember(l, 60, "Less");
		LuaObject.addMember(l, 61, "Equals");
		LuaObject.addMember(l, 62, "Greater");
		LuaObject.addMember(l, 63, "Question");
		LuaObject.addMember(l, 64, "At");
		LuaObject.addMember(l, 91, "LeftBracket");
		LuaObject.addMember(l, 92, "Backslash");
		LuaObject.addMember(l, 93, "RightBracket");
		LuaObject.addMember(l, 94, "Caret");
		LuaObject.addMember(l, 95, "Underscore");
		LuaObject.addMember(l, 96, "BackQuote");
		LuaObject.addMember(l, 97, "A");
		LuaObject.addMember(l, 98, "B");
		LuaObject.addMember(l, 99, "C");
		LuaObject.addMember(l, 100, "D");
		LuaObject.addMember(l, 101, "E");
		LuaObject.addMember(l, 102, "F");
		LuaObject.addMember(l, 103, "G");
		LuaObject.addMember(l, 104, "H");
		LuaObject.addMember(l, 105, "I");
		LuaObject.addMember(l, 106, "J");
		LuaObject.addMember(l, 107, "K");
		LuaObject.addMember(l, 108, "L");
		LuaObject.addMember(l, 109, "M");
		LuaObject.addMember(l, 110, "N");
		LuaObject.addMember(l, 111, "O");
		LuaObject.addMember(l, 112, "P");
		LuaObject.addMember(l, 113, "Q");
		LuaObject.addMember(l, 114, "R");
		LuaObject.addMember(l, 115, "S");
		LuaObject.addMember(l, 116, "T");
		LuaObject.addMember(l, 117, "U");
		LuaObject.addMember(l, 118, "V");
		LuaObject.addMember(l, 119, "W");
		LuaObject.addMember(l, 120, "X");
		LuaObject.addMember(l, 121, "Y");
		LuaObject.addMember(l, 122, "Z");
		LuaObject.addMember(l, 127, "Delete");
		LuaObject.addMember(l, 256, "Keypad0");
		LuaObject.addMember(l, 257, "Keypad1");
		LuaObject.addMember(l, 258, "Keypad2");
		LuaObject.addMember(l, 259, "Keypad3");
		LuaObject.addMember(l, 260, "Keypad4");
		LuaObject.addMember(l, 261, "Keypad5");
		LuaObject.addMember(l, 262, "Keypad6");
		LuaObject.addMember(l, 263, "Keypad7");
		LuaObject.addMember(l, 264, "Keypad8");
		LuaObject.addMember(l, 265, "Keypad9");
		LuaObject.addMember(l, 266, "KeypadPeriod");
		LuaObject.addMember(l, 267, "KeypadDivide");
		LuaObject.addMember(l, 268, "KeypadMultiply");
		LuaObject.addMember(l, 269, "KeypadMinus");
		LuaObject.addMember(l, 270, "KeypadPlus");
		LuaObject.addMember(l, 271, "KeypadEnter");
		LuaObject.addMember(l, 272, "KeypadEquals");
		LuaObject.addMember(l, 273, "UpArrow");
		LuaObject.addMember(l, 274, "DownArrow");
		LuaObject.addMember(l, 275, "RightArrow");
		LuaObject.addMember(l, 276, "LeftArrow");
		LuaObject.addMember(l, 277, "Insert");
		LuaObject.addMember(l, 278, "Home");
		LuaObject.addMember(l, 279, "End");
		LuaObject.addMember(l, 280, "PageUp");
		LuaObject.addMember(l, 281, "PageDown");
		LuaObject.addMember(l, 282, "F1");
		LuaObject.addMember(l, 283, "F2");
		LuaObject.addMember(l, 284, "F3");
		LuaObject.addMember(l, 285, "F4");
		LuaObject.addMember(l, 286, "F5");
		LuaObject.addMember(l, 287, "F6");
		LuaObject.addMember(l, 288, "F7");
		LuaObject.addMember(l, 289, "F8");
		LuaObject.addMember(l, 290, "F9");
		LuaObject.addMember(l, 291, "F10");
		LuaObject.addMember(l, 292, "F11");
		LuaObject.addMember(l, 293, "F12");
		LuaObject.addMember(l, 294, "F13");
		LuaObject.addMember(l, 295, "F14");
		LuaObject.addMember(l, 296, "F15");
		LuaObject.addMember(l, 300, "Numlock");
		LuaObject.addMember(l, 301, "CapsLock");
		LuaObject.addMember(l, 302, "ScrollLock");
		LuaObject.addMember(l, 303, "RightShift");
		LuaObject.addMember(l, 304, "LeftShift");
		LuaObject.addMember(l, 305, "RightControl");
		LuaObject.addMember(l, 306, "LeftControl");
		LuaObject.addMember(l, 307, "RightAlt");
		LuaObject.addMember(l, 308, "LeftAlt");
		LuaObject.addMember(l, 309, "RightApple");
		LuaObject.addMember(l, 309, "RightCommand");
		LuaObject.addMember(l, 310, "LeftCommand");
		LuaObject.addMember(l, 310, "LeftApple");
		LuaObject.addMember(l, 311, "LeftWindows");
		LuaObject.addMember(l, 312, "RightWindows");
		LuaObject.addMember(l, 313, "AltGr");
		LuaObject.addMember(l, 315, "Help");
		LuaObject.addMember(l, 316, "Print");
		LuaObject.addMember(l, 317, "SysReq");
		LuaObject.addMember(l, 318, "Break");
		LuaObject.addMember(l, 319, "Menu");
		LuaObject.addMember(l, 323, "Mouse0");
		LuaObject.addMember(l, 324, "Mouse1");
		LuaObject.addMember(l, 325, "Mouse2");
		LuaObject.addMember(l, 326, "Mouse3");
		LuaObject.addMember(l, 327, "Mouse4");
		LuaObject.addMember(l, 328, "Mouse5");
		LuaObject.addMember(l, 329, "Mouse6");
		LuaObject.addMember(l, 330, "JoystickButton0");
		LuaObject.addMember(l, 331, "JoystickButton1");
		LuaObject.addMember(l, 332, "JoystickButton2");
		LuaObject.addMember(l, 333, "JoystickButton3");
		LuaObject.addMember(l, 334, "JoystickButton4");
		LuaObject.addMember(l, 335, "JoystickButton5");
		LuaObject.addMember(l, 336, "JoystickButton6");
		LuaObject.addMember(l, 337, "JoystickButton7");
		LuaObject.addMember(l, 338, "JoystickButton8");
		LuaObject.addMember(l, 339, "JoystickButton9");
		LuaObject.addMember(l, 340, "JoystickButton10");
		LuaObject.addMember(l, 341, "JoystickButton11");
		LuaObject.addMember(l, 342, "JoystickButton12");
		LuaObject.addMember(l, 343, "JoystickButton13");
		LuaObject.addMember(l, 344, "JoystickButton14");
		LuaObject.addMember(l, 345, "JoystickButton15");
		LuaObject.addMember(l, 346, "JoystickButton16");
		LuaObject.addMember(l, 347, "JoystickButton17");
		LuaObject.addMember(l, 348, "JoystickButton18");
		LuaObject.addMember(l, 349, "JoystickButton19");
		LuaObject.addMember(l, 350, "Joystick1Button0");
		LuaObject.addMember(l, 351, "Joystick1Button1");
		LuaObject.addMember(l, 352, "Joystick1Button2");
		LuaObject.addMember(l, 353, "Joystick1Button3");
		LuaObject.addMember(l, 354, "Joystick1Button4");
		LuaObject.addMember(l, 355, "Joystick1Button5");
		LuaObject.addMember(l, 356, "Joystick1Button6");
		LuaObject.addMember(l, 357, "Joystick1Button7");
		LuaObject.addMember(l, 358, "Joystick1Button8");
		LuaObject.addMember(l, 359, "Joystick1Button9");
		LuaObject.addMember(l, 360, "Joystick1Button10");
		LuaObject.addMember(l, 361, "Joystick1Button11");
		LuaObject.addMember(l, 362, "Joystick1Button12");
		LuaObject.addMember(l, 363, "Joystick1Button13");
		LuaObject.addMember(l, 364, "Joystick1Button14");
		LuaObject.addMember(l, 365, "Joystick1Button15");
		LuaObject.addMember(l, 366, "Joystick1Button16");
		LuaObject.addMember(l, 367, "Joystick1Button17");
		LuaObject.addMember(l, 368, "Joystick1Button18");
		LuaObject.addMember(l, 369, "Joystick1Button19");
		LuaObject.addMember(l, 370, "Joystick2Button0");
		LuaObject.addMember(l, 371, "Joystick2Button1");
		LuaObject.addMember(l, 372, "Joystick2Button2");
		LuaObject.addMember(l, 373, "Joystick2Button3");
		LuaObject.addMember(l, 374, "Joystick2Button4");
		LuaObject.addMember(l, 375, "Joystick2Button5");
		LuaObject.addMember(l, 376, "Joystick2Button6");
		LuaObject.addMember(l, 377, "Joystick2Button7");
		LuaObject.addMember(l, 378, "Joystick2Button8");
		LuaObject.addMember(l, 379, "Joystick2Button9");
		LuaObject.addMember(l, 380, "Joystick2Button10");
		LuaObject.addMember(l, 381, "Joystick2Button11");
		LuaObject.addMember(l, 382, "Joystick2Button12");
		LuaObject.addMember(l, 383, "Joystick2Button13");
		LuaObject.addMember(l, 384, "Joystick2Button14");
		LuaObject.addMember(l, 385, "Joystick2Button15");
		LuaObject.addMember(l, 386, "Joystick2Button16");
		LuaObject.addMember(l, 387, "Joystick2Button17");
		LuaObject.addMember(l, 388, "Joystick2Button18");
		LuaObject.addMember(l, 389, "Joystick2Button19");
		LuaObject.addMember(l, 390, "Joystick3Button0");
		LuaObject.addMember(l, 391, "Joystick3Button1");
		LuaObject.addMember(l, 392, "Joystick3Button2");
		LuaObject.addMember(l, 393, "Joystick3Button3");
		LuaObject.addMember(l, 394, "Joystick3Button4");
		LuaObject.addMember(l, 395, "Joystick3Button5");
		LuaObject.addMember(l, 396, "Joystick3Button6");
		LuaObject.addMember(l, 397, "Joystick3Button7");
		LuaObject.addMember(l, 398, "Joystick3Button8");
		LuaObject.addMember(l, 399, "Joystick3Button9");
		LuaObject.addMember(l, 400, "Joystick3Button10");
		LuaObject.addMember(l, 401, "Joystick3Button11");
		LuaObject.addMember(l, 402, "Joystick3Button12");
		LuaObject.addMember(l, 403, "Joystick3Button13");
		LuaObject.addMember(l, 404, "Joystick3Button14");
		LuaObject.addMember(l, 405, "Joystick3Button15");
		LuaObject.addMember(l, 406, "Joystick3Button16");
		LuaObject.addMember(l, 407, "Joystick3Button17");
		LuaObject.addMember(l, 408, "Joystick3Button18");
		LuaObject.addMember(l, 409, "Joystick3Button19");
		LuaObject.addMember(l, 410, "Joystick4Button0");
		LuaObject.addMember(l, 411, "Joystick4Button1");
		LuaObject.addMember(l, 412, "Joystick4Button2");
		LuaObject.addMember(l, 413, "Joystick4Button3");
		LuaObject.addMember(l, 414, "Joystick4Button4");
		LuaObject.addMember(l, 415, "Joystick4Button5");
		LuaObject.addMember(l, 416, "Joystick4Button6");
		LuaObject.addMember(l, 417, "Joystick4Button7");
		LuaObject.addMember(l, 418, "Joystick4Button8");
		LuaObject.addMember(l, 419, "Joystick4Button9");
		LuaObject.addMember(l, 420, "Joystick4Button10");
		LuaObject.addMember(l, 421, "Joystick4Button11");
		LuaObject.addMember(l, 422, "Joystick4Button12");
		LuaObject.addMember(l, 423, "Joystick4Button13");
		LuaObject.addMember(l, 424, "Joystick4Button14");
		LuaObject.addMember(l, 425, "Joystick4Button15");
		LuaObject.addMember(l, 426, "Joystick4Button16");
		LuaObject.addMember(l, 427, "Joystick4Button17");
		LuaObject.addMember(l, 428, "Joystick4Button18");
		LuaObject.addMember(l, 429, "Joystick4Button19");
		LuaObject.addMember(l, 430, "Joystick5Button0");
		LuaObject.addMember(l, 431, "Joystick5Button1");
		LuaObject.addMember(l, 432, "Joystick5Button2");
		LuaObject.addMember(l, 433, "Joystick5Button3");
		LuaObject.addMember(l, 434, "Joystick5Button4");
		LuaObject.addMember(l, 435, "Joystick5Button5");
		LuaObject.addMember(l, 436, "Joystick5Button6");
		LuaObject.addMember(l, 437, "Joystick5Button7");
		LuaObject.addMember(l, 438, "Joystick5Button8");
		LuaObject.addMember(l, 439, "Joystick5Button9");
		LuaObject.addMember(l, 440, "Joystick5Button10");
		LuaObject.addMember(l, 441, "Joystick5Button11");
		LuaObject.addMember(l, 442, "Joystick5Button12");
		LuaObject.addMember(l, 443, "Joystick5Button13");
		LuaObject.addMember(l, 444, "Joystick5Button14");
		LuaObject.addMember(l, 445, "Joystick5Button15");
		LuaObject.addMember(l, 446, "Joystick5Button16");
		LuaObject.addMember(l, 447, "Joystick5Button17");
		LuaObject.addMember(l, 448, "Joystick5Button18");
		LuaObject.addMember(l, 449, "Joystick5Button19");
		LuaObject.addMember(l, 450, "Joystick6Button0");
		LuaObject.addMember(l, 451, "Joystick6Button1");
		LuaObject.addMember(l, 452, "Joystick6Button2");
		LuaObject.addMember(l, 453, "Joystick6Button3");
		LuaObject.addMember(l, 454, "Joystick6Button4");
		LuaObject.addMember(l, 455, "Joystick6Button5");
		LuaObject.addMember(l, 456, "Joystick6Button6");
		LuaObject.addMember(l, 457, "Joystick6Button7");
		LuaObject.addMember(l, 458, "Joystick6Button8");
		LuaObject.addMember(l, 459, "Joystick6Button9");
		LuaObject.addMember(l, 460, "Joystick6Button10");
		LuaObject.addMember(l, 461, "Joystick6Button11");
		LuaObject.addMember(l, 462, "Joystick6Button12");
		LuaObject.addMember(l, 463, "Joystick6Button13");
		LuaObject.addMember(l, 464, "Joystick6Button14");
		LuaObject.addMember(l, 465, "Joystick6Button15");
		LuaObject.addMember(l, 466, "Joystick6Button16");
		LuaObject.addMember(l, 467, "Joystick6Button17");
		LuaObject.addMember(l, 468, "Joystick6Button18");
		LuaObject.addMember(l, 469, "Joystick6Button19");
		LuaObject.addMember(l, 470, "Joystick7Button0");
		LuaObject.addMember(l, 471, "Joystick7Button1");
		LuaObject.addMember(l, 472, "Joystick7Button2");
		LuaObject.addMember(l, 473, "Joystick7Button3");
		LuaObject.addMember(l, 474, "Joystick7Button4");
		LuaObject.addMember(l, 475, "Joystick7Button5");
		LuaObject.addMember(l, 476, "Joystick7Button6");
		LuaObject.addMember(l, 477, "Joystick7Button7");
		LuaObject.addMember(l, 478, "Joystick7Button8");
		LuaObject.addMember(l, 479, "Joystick7Button9");
		LuaObject.addMember(l, 480, "Joystick7Button10");
		LuaObject.addMember(l, 481, "Joystick7Button11");
		LuaObject.addMember(l, 482, "Joystick7Button12");
		LuaObject.addMember(l, 483, "Joystick7Button13");
		LuaObject.addMember(l, 484, "Joystick7Button14");
		LuaObject.addMember(l, 485, "Joystick7Button15");
		LuaObject.addMember(l, 486, "Joystick7Button16");
		LuaObject.addMember(l, 487, "Joystick7Button17");
		LuaObject.addMember(l, 488, "Joystick7Button18");
		LuaObject.addMember(l, 489, "Joystick7Button19");
		LuaObject.addMember(l, 490, "Joystick8Button0");
		LuaObject.addMember(l, 491, "Joystick8Button1");
		LuaObject.addMember(l, 492, "Joystick8Button2");
		LuaObject.addMember(l, 493, "Joystick8Button3");
		LuaObject.addMember(l, 494, "Joystick8Button4");
		LuaObject.addMember(l, 495, "Joystick8Button5");
		LuaObject.addMember(l, 496, "Joystick8Button6");
		LuaObject.addMember(l, 497, "Joystick8Button7");
		LuaObject.addMember(l, 498, "Joystick8Button8");
		LuaObject.addMember(l, 499, "Joystick8Button9");
		LuaObject.addMember(l, 500, "Joystick8Button10");
		LuaObject.addMember(l, 501, "Joystick8Button11");
		LuaObject.addMember(l, 502, "Joystick8Button12");
		LuaObject.addMember(l, 503, "Joystick8Button13");
		LuaObject.addMember(l, 504, "Joystick8Button14");
		LuaObject.addMember(l, 505, "Joystick8Button15");
		LuaObject.addMember(l, 506, "Joystick8Button16");
		LuaObject.addMember(l, 507, "Joystick8Button17");
		LuaObject.addMember(l, 508, "Joystick8Button18");
		LuaObject.addMember(l, 509, "Joystick8Button19");
		LuaDLL.lua_pop(l, 1);
	}
}
