using VL.Lib.IO;
using SharpHook.Data;
using ModifierMask = SharpHook.Data.EventMask;

namespace VL.IO.MouseKeyGlobal
{
    public static class MouseKeyGlobalHelper
    {
        public static MouseButtons MouseButtonLookup(MouseButton mouseButton)
        {
            #region Switch MouseButton
            switch (mouseButton)
            {
                case MouseButton.NoButton:
                    return MouseButtons.None;

                case MouseButton.Button1:
                    return MouseButtons.Left;

                case MouseButton.Button2:
                    return MouseButtons.Right;

                case MouseButton.Button3:
                    return MouseButtons.Middle;

                case MouseButton.Button4:
                    return MouseButtons.XButton1;

                case MouseButton.Button5:
                    return MouseButtons.XButton2;

                default:
                    return MouseButtons.None;
            }
            #endregion
        }

        public static MouseButton MouseButtonReverseLookup(MouseButtons mouseButton)
        {
            #region Switch MouseButton
            switch (mouseButton)
            {
                case MouseButtons.None:
                    return MouseButton.NoButton;

                case MouseButtons.Left:
                    return MouseButton.Button1;

                case MouseButtons.Right:
                    return MouseButton.Button2;

                case MouseButtons.Middle:
                    return MouseButton.Button3;

                case MouseButtons.XButton1:
                    return MouseButton.Button4;

                case MouseButtons.XButton2:
                    return MouseButton.Button5;

                default:
                    return MouseButton.NoButton;
            }
            #endregion
        }

        // https://github.com/kwhat/libuiohook/blob/1.2/include/uiohook.h
        // https://sharphook.tolik.io/articles/keycodes.html
        // https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0

        public static Keys KeyboardKeyLookup(KeyCode keyCode)
        {
            #region Switch Keys

            switch (keyCode)
            {
                case KeyCode.VcEscape:
                    return Keys.Escape;

                case KeyCode.VcF1:
                    return Keys.F1;

                case KeyCode.VcF2:
                    return Keys.F2;

                case KeyCode.VcF3:
                    return Keys.F3;

                case KeyCode.VcF4:
                    return Keys.F4;

                case KeyCode.VcF5:
                    return Keys.F5;

                case KeyCode.VcF6:
                    return Keys.F6;

                case KeyCode.VcF7:
                    return Keys.F7;

                case KeyCode.VcF8:
                    return Keys.F8;

                case KeyCode.VcF9:
                    return Keys.F9;

                case KeyCode.VcF10:
                    return Keys.F10;

                case KeyCode.VcF11:
                    return Keys.F11;

                case KeyCode.VcF12:
                    return Keys.F12;

                case KeyCode.VcF13:
                    return Keys.F13;

                case KeyCode.VcF14:
                    return Keys.F14;

                case KeyCode.VcF15:
                    return Keys.F15;

                case KeyCode.VcF16:
                    return Keys.F16;

                case KeyCode.VcF17:
                    return Keys.F17;

                case KeyCode.VcF18:
                    return Keys.F18;

                case KeyCode.VcF19:
                    return Keys.F19;

                case KeyCode.VcF20:
                    return Keys.F20;

                case KeyCode.VcF21:
                    return Keys.F21;

                case KeyCode.VcF22:
                    return Keys.F22;

                case KeyCode.VcF23:
                    return Keys.F23;

                case KeyCode.VcF24:
                    return Keys.F24;

                case KeyCode.VcBackQuote:
                    return Keys.Oemtilde;

                case KeyCode.Vc1:
                    return Keys.D1;

                case KeyCode.Vc2:
                    return Keys.D2;

                case KeyCode.Vc3:
                    return Keys.D3;

                case KeyCode.Vc4:
                    return Keys.D4;

                case KeyCode.Vc5:
                    return Keys.D5;

                case KeyCode.Vc6:
                    return Keys.D6;

                case KeyCode.Vc7:
                    return Keys.D7;

                case KeyCode.Vc8:
                    return Keys.D8;

                case KeyCode.Vc9:
                    return Keys.D9;

                case KeyCode.Vc0:
                    return Keys.D0;

                case KeyCode.VcMinus:
                    return Keys.OemMinus;

                case KeyCode.VcEquals:
                    return Keys.Oemplus;

                case KeyCode.VcBackspace:
                    return Keys.Back;

                case KeyCode.VcTab:
                    return Keys.Tab;

                case KeyCode.VcCapsLock:
                    return Keys.Capital;

                case KeyCode.VcA:
                    return Keys.A;

                case KeyCode.VcB:
                    return Keys.B;

                case KeyCode.VcC:
                    return Keys.C;

                case KeyCode.VcD:
                    return Keys.D;

                case KeyCode.VcE:
                    return Keys.E;

                case KeyCode.VcF:
                    return Keys.F;

                case KeyCode.VcG:
                    return Keys.G;

                case KeyCode.VcH:
                    return Keys.H;

                case KeyCode.VcI:
                    return Keys.I;

                case KeyCode.VcJ:
                    return Keys.J;

                case KeyCode.VcK:
                    return Keys.K;

                case KeyCode.VcL:
                    return Keys.L;

                case KeyCode.VcM:
                    return Keys.M;

                case KeyCode.VcN:
                    return Keys.N;

                case KeyCode.VcO:
                    return Keys.O;

                case KeyCode.VcP:
                    return Keys.P;

                case KeyCode.VcQ:
                    return Keys.Q;

                case KeyCode.VcR:
                    return Keys.R;

                case KeyCode.VcS:
                    return Keys.S;

                case KeyCode.VcT:
                    return Keys.T;

                case KeyCode.VcU:
                    return Keys.U;

                case KeyCode.VcV:
                    return Keys.V;

                case KeyCode.VcW:
                    return Keys.W;

                case KeyCode.VcX:
                    return Keys.X;

                case KeyCode.VcY:
                    return Keys.Y;

                case KeyCode.VcZ:
                    return Keys.Z;

                case KeyCode.VcOpenBracket:
                    return Keys.OemOpenBrackets;

                case KeyCode.VcCloseBracket:
                    return Keys.Oem6;

                case KeyCode.VcBackslash:
                    return Keys.Oem5;

                case KeyCode.VcSemicolon:
                    return Keys.Oem1;

                case KeyCode.VcQuote:
                    return Keys.Oem7;

                case KeyCode.VcEnter:
                    return Keys.Return;

                case KeyCode.VcComma:
                    return Keys.Oemcomma;

                case KeyCode.VcPeriod:
                    return Keys.OemPeriod;

                case KeyCode.VcSlash:
                    return Keys.OemQuestion;

                case KeyCode.VcSpace:
                    return Keys.Space;

                case KeyCode.VcPrintScreen:
                    return Keys.PrintScreen;

                case KeyCode.VcScrollLock:
                    return Keys.Scroll;

                case KeyCode.VcPause:
                    return Keys.Pause;

                case KeyCode.Vc102:
                    return Keys.OemBackslash;

                case KeyCode.VcInsert:
                    return Keys.Insert;

                case KeyCode.VcDelete:
                    return Keys.Delete;

                case KeyCode.VcHome:
                    return Keys.Home;

                case KeyCode.VcEnd:
                    return Keys.End;

                case KeyCode.VcPageUp:
                    return Keys.PageUp;

                case KeyCode.VcPageDown:
                    return Keys.PageDown; //? could be Next also

                case KeyCode.VcUp:
                    return Keys.Up;

                case KeyCode.VcLeft:
                    return Keys.Left;

                case KeyCode.VcNumPadClear:
                    return Keys.Clear;

                case KeyCode.VcRight:
                    return Keys.Right;

                case KeyCode.VcDown:
                    return Keys.Down;

                case KeyCode.VcNumLock:
                    return Keys.NumLock;

                case KeyCode.VcNumPadDivide:
                    return Keys.Divide;

                case KeyCode.VcNumPadMultiply:
                    return Keys.Multiply;

                case KeyCode.VcNumPadSubtract:
                    return Keys.Subtract;

                case KeyCode.VcNumPadEquals:
                    return Keys.NoName; // =  0x92 Oem specific

                case KeyCode.VcNumPadAdd:
                    return Keys.Add;

                case KeyCode.VcNumPadEnter:
                    return Keys.Return;

                case KeyCode.VcNumPadDecimal:
                    return Keys.Decimal;

                case KeyCode.VcNumPadSeparator:
                    return Keys.Separator;

                case KeyCode.VcNumPad1:
                    return Keys.NumPad1;

                case KeyCode.VcNumPad2:
                    return Keys.NumPad2;

                case KeyCode.VcNumPad3:
                    return Keys.NumPad3;

                case KeyCode.VcNumPad4:
                    return Keys.NumPad4;

                case KeyCode.VcNumPad5:
                    return Keys.NumPad5;

                case KeyCode.VcNumPad6:
                    return Keys.NumPad6;

                case KeyCode.VcNumPad7:
                    return Keys.NumPad7;

                case KeyCode.VcNumPad8:
                    return Keys.NumPad8;

                case KeyCode.VcNumPad9:
                    return Keys.NumPad9;

                case KeyCode.VcNumPad0:
                    return Keys.NumPad0;

                case KeyCode.VcLeftShift:
                    return Keys.ShiftKey; //Keys.LShiftKey;

                case KeyCode.VcRightShift:
                    return Keys.ShiftKey; //Keys.RShiftKey;

                case KeyCode.VcLeftControl:
                    return Keys.ControlKey; //Keys.LControlKey;

                case KeyCode.VcRightControl:
                    return Keys.ControlKey; //Keys.RControlKey;

                case KeyCode.VcLeftAlt:
                    return Keys.Menu; //Keys.LMenu;

                case KeyCode.VcRightAlt:
                    return Keys.Menu; //Keys.RMenu;

                case KeyCode.VcLeftMeta:
                    return Keys.LWin;

                case KeyCode.VcRightMeta:
                    return Keys.RWin;

                case KeyCode.VcContextMenu:
                    return Keys.Apps;

                case KeyCode.VcSleep:
                    return Keys.Sleep;

                case KeyCode.VcMediaPlay:
                    return Keys.MediaPlayPause;

                case KeyCode.VcMediaStop:
                    return Keys.MediaStop;

                case KeyCode.VcMediaPrevious:
                    return Keys.MediaPreviousTrack;

                case KeyCode.VcMediaNext:
                    return Keys.MediaNextTrack;

                case KeyCode.VcMediaSelect:
                    return Keys.SelectMedia;

                case KeyCode.VcVolumeMute:
                    return Keys.VolumeMute;

                case KeyCode.VcVolumeUp:
                    return Keys.VolumeUp;

                case KeyCode.VcVolumeDown:
                    return Keys.VolumeDown;

                case KeyCode.VcAppMail:
                    return Keys.LaunchMail;

                case KeyCode.VcBrowserSearch:
                    return Keys.BrowserSearch;

                case KeyCode.VcBrowserHome:
                    return Keys.BrowserHome;

                case KeyCode.VcBrowserBack:
                    return Keys.BrowserBack;

                case KeyCode.VcBrowserForward:
                    return Keys.BrowserForward;

                case KeyCode.VcBrowserStop:
                    return Keys.BrowserStop;

                case KeyCode.VcBrowserRefresh:
                    return Keys.BrowserRefresh;

                case KeyCode.VcBrowserFavorites:
                    return Keys.BrowserFavorites;

                case KeyCode.VcKana:
                    return Keys.KanaMode; 

                case KeyCode.VcUnderscore:
                    return Keys.NoName; 

                case KeyCode.VcHanja:
                    return Keys.KanjiMode; 

                case KeyCode.VcUndefined: // KeyCode Unknown
                    return Keys.NoName;

                default:
                    return Keys.NoName;
            }
            #endregion
        }

        public static KeyCode KeyboardReverseKeyLookup(Keys keyCode)
        {
            #region Switch Keys

            switch (keyCode)
            {
                case Keys.Escape:
                    return KeyCode.VcEscape;

                case Keys.F1:
                    return KeyCode.VcF1;

                case Keys.F2:
                    return KeyCode.VcF2;

                case Keys.F3:
                    return KeyCode.VcF3;

                case Keys.F4:
                    return KeyCode.VcF4;

                case Keys.F5:
                    return KeyCode.VcF5;

                case Keys.F6:
                    return KeyCode.VcF6;

                case Keys.F7:
                    return KeyCode.VcF7;

                case Keys.F8:
                    return KeyCode.VcF8;

                case Keys.F9:
                    return KeyCode.VcF9;

                case Keys.F10:
                    return KeyCode.VcF10;

                case Keys.F11:
                    return KeyCode.VcF11;

                case Keys.F12:
                    return KeyCode.VcF12;

                case Keys.F13:
                    return KeyCode.VcF13;

                case Keys.F14:
                    return KeyCode.VcF14;

                case Keys.F15:
                    return KeyCode.VcF15;

                case Keys.F16:
                    return KeyCode.VcF16;

                case Keys.F17:
                    return KeyCode.VcF17;

                case Keys.F18:
                    return KeyCode.VcF18;

                case Keys.F19:
                    return KeyCode.VcF19;

                case Keys.F20:
                    return KeyCode.VcF20;

                case Keys.F21:
                    return KeyCode.VcF21;

                case Keys.F22:
                    return KeyCode.VcF22;

                case Keys.F23:
                    return KeyCode.VcF23;

                case Keys.F24:
                    return KeyCode.VcF24;

                case Keys.Oemtilde:
                    return KeyCode.VcBackQuote;

                case Keys.D1:
                    return KeyCode.Vc1;

                case Keys.D2:
                    return KeyCode.Vc2;

                case Keys.D3:
                    return KeyCode.Vc3;

                case Keys.D4:
                    return KeyCode.Vc4;

                case Keys.D5:
                    return KeyCode.Vc5;

                case Keys.D6:
                    return KeyCode.Vc6;

                case Keys.D7:
                    return KeyCode.Vc7;

                case Keys.D8:
                    return KeyCode.Vc8;

                case Keys.D9:
                    return KeyCode.Vc9;

                case Keys.D0:
                    return KeyCode.Vc0;

                case Keys.OemMinus:
                    return KeyCode.VcMinus;

                case Keys.Oemplus:
                    return KeyCode.VcEquals;

                case Keys.Back:
                    return KeyCode.VcBackspace;

                case Keys.Tab:
                    return KeyCode.VcTab;

                case Keys.Capital:
                    return KeyCode.VcCapsLock;

                case Keys.A:
                    return KeyCode.VcA;

                case Keys.B:
                    return KeyCode.VcB;

                case Keys.C:
                    return KeyCode.VcC;

                case Keys.D:
                    return KeyCode.VcD;

                case Keys.E:
                    return KeyCode.VcE;

                case Keys.F:
                    return KeyCode.VcF;

                case Keys.G:
                    return KeyCode.VcG;

                case Keys.H:
                    return KeyCode.VcH;

                case Keys.I:
                    return KeyCode.VcI;

                case Keys.J:
                    return KeyCode.VcJ;

                case Keys.K:
                    return KeyCode.VcK;

                case Keys.L:
                    return KeyCode.VcL;

                case Keys.M:
                    return KeyCode.VcM;

                case Keys.N:
                    return KeyCode.VcN;

                case Keys.O:
                    return KeyCode.VcO;

                case Keys.P:
                    return KeyCode.VcP;

                case Keys.Q:
                    return KeyCode.VcQ;

                case Keys.R:
                    return KeyCode.VcR;

                case Keys.S:
                    return KeyCode.VcS;

                case Keys.T:
                    return KeyCode.VcT;

                case Keys.U:
                    return KeyCode.VcU;

                case Keys.V:
                    return KeyCode.VcV;

                case Keys.W:
                    return KeyCode.VcW;

                case Keys.X:
                    return KeyCode.VcX;

                case Keys.Y:
                    return KeyCode.VcY;

                case Keys.Z:
                    return KeyCode.VcZ;

                case Keys.OemOpenBrackets:
                    return KeyCode.VcOpenBracket;

                case Keys.Oem6:
                    return KeyCode.VcCloseBracket;

                case Keys.Oem5:
                    return KeyCode.VcBackslash;

                case Keys.Oem1:
                    return KeyCode.VcSemicolon;

                case Keys.Oem7:
                    return KeyCode.VcQuote;

                case Keys.Return:
                    return KeyCode.VcEnter;

                case Keys.Oemcomma:
                    return KeyCode.VcComma;

                case Keys.OemPeriod:
                    return KeyCode.VcPeriod;

                case Keys.OemQuestion:
                    return KeyCode.VcSlash;

                case Keys.Space:
                    return KeyCode.VcSpace;

                case Keys.PrintScreen:
                    return KeyCode.VcPrintScreen;

                case Keys.Scroll:
                    return KeyCode.VcScrollLock;

                case Keys.Pause:
                    return KeyCode.VcPause;

                case Keys.OemBackslash:
                    return KeyCode.Vc102;

                case Keys.Insert:
                    return KeyCode.VcInsert;

                case Keys.Delete:
                    return KeyCode.VcDelete;

                case Keys.Home:
                    return KeyCode.VcHome;

                case Keys.End:
                    return KeyCode.VcEnd;

                case Keys.PageUp:
                    return KeyCode.VcPageUp;

                case Keys.PageDown:
                    return KeyCode.VcPageDown;

                case Keys.Up:
                    return KeyCode.VcUp;

                case Keys.Left:
                    return KeyCode.VcLeft;

                case Keys.OemClear:
                    return KeyCode.VcNumPadClear;

                case Keys.Right:
                    return KeyCode.VcRight;

                case Keys.Down:
                    return KeyCode.VcDown;

                case Keys.NumLock:
                    return KeyCode.VcNumLock;

                case Keys.Divide:
                    return KeyCode.VcNumPadDivide;

                case Keys.Multiply:
                    return KeyCode.VcNumPadMultiply;

                case Keys.Subtract:
                    return KeyCode.VcNumPadSubtract;

                case Keys.Add:
                    return KeyCode.VcNumPadAdd;

                case Keys.Decimal:
                    return KeyCode.VcNumPadDecimal;

                case Keys.Separator:
                    return KeyCode.VcNumPadSeparator;

                case Keys.NumPad1:
                    return KeyCode.VcNumPad1;

                case Keys.NumPad2:
                    return KeyCode.VcNumPad2;

                case Keys.NumPad3:
                    return KeyCode.VcNumPad3;

                case Keys.NumPad4:
                    return KeyCode.VcNumPad4;

                case Keys.NumPad5:
                    return KeyCode.VcNumPad5;

                case Keys.NumPad6:
                    return KeyCode.VcNumPad6;

                case Keys.NumPad7:
                    return KeyCode.VcNumPad7;

                case Keys.NumPad8:
                    return KeyCode.VcNumPad8;

                case Keys.NumPad9:
                    return KeyCode.VcNumPad9;

                case Keys.NumPad0:
                    return KeyCode.VcNumPad0;

                case Keys.LShiftKey:
                    return KeyCode.VcLeftShift;

                case Keys.RShiftKey:
                    return KeyCode.VcRightShift;

                case Keys.LControlKey:
                    return KeyCode.VcLeftControl;

                case Keys.RControlKey:
                    return KeyCode.VcRightControl;

                case Keys.LMenu:
                    return KeyCode.VcLeftAlt;

                case Keys.RMenu:
                    return KeyCode.VcRightAlt;

                case Keys.LWin:
                    return KeyCode.VcLeftMeta;

                case Keys.RWin:
                    return KeyCode.VcRightMeta;

                case Keys.Sleep:
                    return KeyCode.VcSleep;

                case Keys.MediaPlayPause:
                    return KeyCode.VcMediaPlay;

                case Keys.MediaStop:
                    return KeyCode.VcMediaStop;

                case Keys.MediaPreviousTrack:
                    return KeyCode.VcMediaPrevious;

                case Keys.MediaNextTrack:
                    return KeyCode.VcMediaNext;

                case Keys.VolumeMute:
                    return KeyCode.VcVolumeMute;

                case Keys.VolumeUp:
                    return KeyCode.VcVolumeUp;

                case Keys.VolumeDown:
                    return KeyCode.VcVolumeDown;

                case Keys.LaunchMail:
                    return KeyCode.VcAppMail;

                case Keys.BrowserSearch:
                    return KeyCode.VcBrowserSearch;

                case Keys.BrowserHome:
                    return KeyCode.VcBrowserHome;

                case Keys.BrowserBack:
                    return KeyCode.VcBrowserBack;

                case Keys.BrowserForward:
                    return KeyCode.VcBrowserForward;

                case Keys.BrowserStop:
                    return KeyCode.VcBrowserStop;

                case Keys.BrowserRefresh:
                    return KeyCode.VcBrowserRefresh;

                case Keys.BrowserFavorites:
                    return KeyCode.VcBrowserFavorites;

                case Keys.KanaMode:
                    return KeyCode.VcKana;

                case Keys.KanjiMode:
                    return KeyCode.VcHanja;

                case Keys.NoName:
                    return KeyCode.VcUndefined;

                default:
                    return KeyCode.VcUndefined;
            }
            #endregion
        }

        public static Keys ModifierMaskLookup(ModifierMask modifierMask)
        {
            #region Switch ModifierMask
            switch (modifierMask)
            {
                case ModifierMask.Alt:
                    return Keys.Alt;

                case ModifierMask.Button1:
                    return Keys.LButton;

                case ModifierMask.Button2:
                    return Keys.RButton;

                case ModifierMask.Button3:
                    return Keys.MButton;

                case ModifierMask.Button4:
                    return Keys.XButton1;

                case ModifierMask.Button5:
                    return Keys.XButton2;

                case ModifierMask.CapsLock:
                    return Keys.CapsLock;

                case ModifierMask.Ctrl:
                    return Keys.ControlKey;

                case ModifierMask.LeftAlt:
                    return Keys.LMenu;

                case ModifierMask.LeftCtrl:
                    return Keys.LControlKey;

                case ModifierMask.LeftMeta:
                    return Keys.LWin;

                case ModifierMask.LeftShift:
                    return Keys.LShiftKey;

                case ModifierMask.Meta:
                    return Keys.LWin;

                case ModifierMask.NumLock:
                    return Keys.NumLock;

                case ModifierMask.RightAlt:
                    return Keys.RMenu;

                case ModifierMask.RightCtrl:
                    return Keys.RControlKey;

                case ModifierMask.RightMeta:
                    return Keys.RWin;

                case ModifierMask.RightShift:
                    return Keys.RShiftKey;

                case ModifierMask.ScrollLock:
                    return Keys.Scroll;

                case ModifierMask.Shift:
                    return Keys.ShiftKey;

                case ModifierMask.None:
                    return Keys.None;

                default:
                    return Keys.NoName;

            }
            #endregion
        }
    }
}