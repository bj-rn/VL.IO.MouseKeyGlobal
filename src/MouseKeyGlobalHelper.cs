using System;
using MouseButton = SharpHook.Native.MouseButton;
using KeyCode = SharpHook.Native.KeyCode;
using ModifierMask = SharpHook.Native.ModifierMask;

namespace VL.IO.MouseKeyGlobal
{

    /* 
        The Keys in these enums are exactly the ones in System.Windows.Forms. 
        The vvvv mouse nodes use them but I didn't want to have a dependency on Winforms.
     */

    #region Keys enum

    //
    // Summary:
    //     Specifies key codes and modifiers.
    public enum Keys
    {
        //
        // Summary:
        //     The bitmask to extract a key code from a key value.
        KeyCode = 0xFFFF,
        //
        // Summary:
        //     The bitmask to extract modifiers from a key value.
        Modifiers = -65536,
        //
        // Summary:
        //     No key pressed.
        None = 0x0,
        //
        // Summary:
        //     The left mouse button.
        LButton = 0x1,
        //
        // Summary:
        //     The right mouse button.
        RButton = 0x2,
        //
        // Summary:
        //     The CANCEL key.
        Cancel = 0x3,
        //
        // Summary:
        //     The middle mouse button (three-button mouse).
        MButton = 0x4,
        //
        // Summary:
        //     The first x mouse button (five-button mouse).
        XButton1 = 0x5,
        //
        // Summary:
        //     The second x mouse button (five-button mouse).
        XButton2 = 0x6,
        //
        // Summary:
        //     The BACKSPACE key.
        Back = 0x8,
        //
        // Summary:
        //     The TAB key.
        Tab = 0x9,
        //
        // Summary:
        //     The LINEFEED key.
        LineFeed = 0xA,
        //
        // Summary:
        //     The CLEAR key.
        Clear = 0xC,
        //
        // Summary:
        //     The RETURN key.
        Return = 0xD,
        //
        // Summary:
        //     The ENTER key.
        Enter = 0xD,
        //
        // Summary:
        //     The SHIFT key.
        ShiftKey = 0x10,
        //
        // Summary:
        //     The CTRL key.
        ControlKey = 0x11,
        //
        // Summary:
        //     The ALT key.
        Menu = 0x12,
        //
        // Summary:
        //     The PAUSE key.
        Pause = 0x13,
        //
        // Summary:
        //     The CAPS LOCK key.
        Capital = 0x14,
        //
        // Summary:
        //     The CAPS LOCK key.
        CapsLock = 0x14,
        //
        // Summary:
        //     The IME Kana mode key.
        KanaMode = 0x15,
        //
        // Summary:
        //     The IME Hanguel mode key. (maintained for compatibility; use HangulMode)
        HanguelMode = 0x15,
        //
        // Summary:
        //     The IME Hangul mode key.
        HangulMode = 0x15,
        //
        // Summary:
        //     The IME Junja mode key.
        JunjaMode = 0x17,
        //
        // Summary:
        //     The IME final mode key.
        FinalMode = 0x18,
        //
        // Summary:
        //     The IME Hanja mode key.
        HanjaMode = 0x19,
        //
        // Summary:
        //     The IME Kanji mode key.
        KanjiMode = 0x19,
        //
        // Summary:
        //     The ESC key.
        Escape = 0x1B,
        //
        // Summary:
        //     The IME convert key.
        IMEConvert = 0x1C,
        //
        // Summary:
        //     The IME nonconvert key.
        IMENonconvert = 0x1D,
        //
        // Summary:
        //     The IME accept key, replaces System.Windows.Forms.Keys.IMEAceept.
        IMEAccept = 0x1E,
        //
        // Summary:
        //     The IME accept key. Obsolete, use System.Windows.Forms.Keys.IMEAccept instead.
        IMEAceept = 0x1E,
        //
        // Summary:
        //     The IME mode change key.
        IMEModeChange = 0x1F,
        //
        // Summary:
        //     The SPACEBAR key.
        Space = 0x20,
        //
        // Summary:
        //     The PAGE UP key.
        Prior = 0x21,
        //
        // Summary:
        //     The PAGE UP key.
        PageUp = 0x21,
        //
        // Summary:
        //     The PAGE DOWN key.
        Next = 0x22,
        //
        // Summary:
        //     The PAGE DOWN key.
        PageDown = 0x22,
        //
        // Summary:
        //     The END key.
        End = 0x23,
        //
        // Summary:
        //     The HOME key.
        Home = 0x24,
        //
        // Summary:
        //     The LEFT ARROW key.
        Left = 0x25,
        //
        // Summary:
        //     The UP ARROW key.
        Up = 0x26,
        //
        // Summary:
        //     The RIGHT ARROW key.
        Right = 0x27,
        //
        // Summary:
        //     The DOWN ARROW key.
        Down = 0x28,
        //
        // Summary:
        //     The SELECT key.
        Select = 0x29,
        //
        // Summary:
        //     The PRINT key.
        Print = 0x2A,
        //
        // Summary:
        //     The EXECUTE key.
        Execute = 0x2B,
        //
        // Summary:
        //     The PRINT SCREEN key.
        Snapshot = 0x2C,
        //
        // Summary:
        //     The PRINT SCREEN key.
        PrintScreen = 0x2C,
        //
        // Summary:
        //     The INS key.
        Insert = 0x2D,
        //
        // Summary:
        //     The DEL key.
        Delete = 0x2E,
        //
        // Summary:
        //     The HELP key.
        Help = 0x2F,
        //
        // Summary:
        //     The 0 key.
        D0 = 0x30,
        //
        // Summary:
        //     The 1 key.
        D1 = 0x31,
        //
        // Summary:
        //     The 2 key.
        D2 = 0x32,
        //
        // Summary:
        //     The 3 key.
        D3 = 0x33,
        //
        // Summary:
        //     The 4 key.
        D4 = 0x34,
        //
        // Summary:
        //     The 5 key.
        D5 = 0x35,
        //
        // Summary:
        //     The 6 key.
        D6 = 0x36,
        //
        // Summary:
        //     The 7 key.
        D7 = 0x37,
        //
        // Summary:
        //     The 8 key.
        D8 = 0x38,
        //
        // Summary:
        //     The 9 key.
        D9 = 0x39,
        //
        // Summary:
        //     The A key.
        A = 0x41,
        //
        // Summary:
        //     The B key.
        B = 0x42,
        //
        // Summary:
        //     The C key.
        C = 0x43,
        //
        // Summary:
        //     The D key.
        D = 0x44,
        //
        // Summary:
        //     The E key.
        E = 0x45,
        //
        // Summary:
        //     The F key.
        F = 0x46,
        //
        // Summary:
        //     The G key.
        G = 0x47,
        //
        // Summary:
        //     The H key.
        H = 0x48,
        //
        // Summary:
        //     The I key.
        I = 0x49,
        //
        // Summary:
        //     The J key.
        J = 0x4A,
        //
        // Summary:
        //     The K key.
        K = 0x4B,
        //
        // Summary:
        //     The L key.
        L = 0x4C,
        //
        // Summary:
        //     The M key.
        M = 0x4D,
        //
        // Summary:
        //     The N key.
        N = 0x4E,
        //
        // Summary:
        //     The O key.
        O = 0x4F,
        //
        // Summary:
        //     The P key.
        P = 0x50,
        //
        // Summary:
        //     The Q key.
        Q = 0x51,
        //
        // Summary:
        //     The R key.
        R = 0x52,
        //
        // Summary:
        //     The S key.
        S = 0x53,
        //
        // Summary:
        //     The T key.
        T = 0x54,
        //
        // Summary:
        //     The U key.
        U = 0x55,
        //
        // Summary:
        //     The V key.
        V = 0x56,
        //
        // Summary:
        //     The W key.
        W = 0x57,
        //
        // Summary:
        //     The X key.
        X = 0x58,
        //
        // Summary:
        //     The Y key.
        Y = 0x59,
        //
        // Summary:
        //     The Z key.
        Z = 0x5A,
        //
        // Summary:
        //     The left Windows logo key (Microsoft Natural Keyboard).
        LWin = 0x5B,
        //
        // Summary:
        //     The right Windows logo key (Microsoft Natural Keyboard).
        RWin = 0x5C,
        //
        // Summary:
        //     The application key (Microsoft Natural Keyboard).
        Apps = 0x5D,
        //
        // Summary:
        //     The computer sleep key.
        Sleep = 0x5F,
        //
        // Summary:
        //     The 0 key on the numeric keypad.
        NumPad0 = 0x60,
        //
        // Summary:
        //     The 1 key on the numeric keypad.
        NumPad1 = 0x61,
        //
        // Summary:
        //     The 2 key on the numeric keypad.
        NumPad2 = 0x62,
        //
        // Summary:
        //     The 3 key on the numeric keypad.
        NumPad3 = 0x63,
        //
        // Summary:
        //     The 4 key on the numeric keypad.
        NumPad4 = 0x64,
        //
        // Summary:
        //     The 5 key on the numeric keypad.
        NumPad5 = 0x65,
        //
        // Summary:
        //     The 6 key on the numeric keypad.
        NumPad6 = 0x66,
        //
        // Summary:
        //     The 7 key on the numeric keypad.
        NumPad7 = 0x67,
        //
        // Summary:
        //     The 8 key on the numeric keypad.
        NumPad8 = 0x68,
        //
        // Summary:
        //     The 9 key on the numeric keypad.
        NumPad9 = 0x69,
        //
        // Summary:
        //     The multiply key.
        Multiply = 0x6A,
        //
        // Summary:
        //     The add key.
        Add = 0x6B,
        //
        // Summary:
        //     The separator key.
        Separator = 0x6C,
        //
        // Summary:
        //     The subtract key.
        Subtract = 0x6D,
        //
        // Summary:
        //     The decimal key.
        Decimal = 0x6E,
        //
        // Summary:
        //     The divide key.
        Divide = 0x6F,
        //
        // Summary:
        //     The F1 key.
        F1 = 0x70,
        //
        // Summary:
        //     The F2 key.
        F2 = 0x71,
        //
        // Summary:
        //     The F3 key.
        F3 = 0x72,
        //
        // Summary:
        //     The F4 key.
        F4 = 0x73,
        //
        // Summary:
        //     The F5 key.
        F5 = 0x74,
        //
        // Summary:
        //     The F6 key.
        F6 = 0x75,
        //
        // Summary:
        //     The F7 key.
        F7 = 0x76,
        //
        // Summary:
        //     The F8 key.
        F8 = 0x77,
        //
        // Summary:
        //     The F9 key.
        F9 = 0x78,
        //
        // Summary:
        //     The F10 key.
        F10 = 0x79,
        //
        // Summary:
        //     The F11 key.
        F11 = 0x7A,
        //
        // Summary:
        //     The F12 key.
        F12 = 0x7B,
        //
        // Summary:
        //     The F13 key.
        F13 = 0x7C,
        //
        // Summary:
        //     The F14 key.
        F14 = 0x7D,
        //
        // Summary:
        //     The F15 key.
        F15 = 0x7E,
        //
        // Summary:
        //     The F16 key.
        F16 = 0x7F,
        //
        // Summary:
        //     The F17 key.
        F17 = 0x80,
        //
        // Summary:
        //     The F18 key.
        F18 = 0x81,
        //
        // Summary:
        //     The F19 key.
        F19 = 0x82,
        //
        // Summary:
        //     The F20 key.
        F20 = 0x83,
        //
        // Summary:
        //     The F21 key.
        F21 = 0x84,
        //
        // Summary:
        //     The F22 key.
        F22 = 0x85,
        //
        // Summary:
        //     The F23 key.
        F23 = 0x86,
        //
        // Summary:
        //     The F24 key.
        F24 = 0x87,
        //
        // Summary:
        //     The NUM LOCK key.
        NumLock = 0x90,
        //
        // Summary:
        //     The SCROLL LOCK key.
        Scroll = 0x91,
        //
        // Summary:
        //     The left SHIFT key.
        LShiftKey = 0xA0,
        //
        // Summary:
        //     The right SHIFT key.
        RShiftKey = 0xA1,
        //
        // Summary:
        //     The left CTRL key.
        LControlKey = 0xA2,
        //
        // Summary:
        //     The right CTRL key.
        RControlKey = 0xA3,
        //
        // Summary:
        //     The left ALT key.
        LMenu = 0xA4,
        //
        // Summary:
        //     The right ALT key.
        RMenu = 0xA5,
        //
        // Summary:
        //     The browser back key (Windows 2000 or later).
        BrowserBack = 0xA6,
        //
        // Summary:
        //     The browser forward key (Windows 2000 or later).
        BrowserForward = 0xA7,
        //
        // Summary:
        //     The browser refresh key (Windows 2000 or later).
        BrowserRefresh = 0xA8,
        //
        // Summary:
        //     The browser stop key (Windows 2000 or later).
        BrowserStop = 0xA9,
        //
        // Summary:
        //     The browser search key (Windows 2000 or later).
        BrowserSearch = 0xAA,
        //
        // Summary:
        //     The browser favorites key (Windows 2000 or later).
        BrowserFavorites = 0xAB,
        //
        // Summary:
        //     The browser home key (Windows 2000 or later).
        BrowserHome = 0xAC,
        //
        // Summary:
        //     The volume mute key (Windows 2000 or later).
        VolumeMute = 0xAD,
        //
        // Summary:
        //     The volume down key (Windows 2000 or later).
        VolumeDown = 0xAE,
        //
        // Summary:
        //     The volume up key (Windows 2000 or later).
        VolumeUp = 0xAF,
        //
        // Summary:
        //     The media next track key (Windows 2000 or later).
        MediaNextTrack = 0xB0,
        //
        // Summary:
        //     The media previous track key (Windows 2000 or later).
        MediaPreviousTrack = 0xB1,
        //
        // Summary:
        //     The media Stop key (Windows 2000 or later).
        MediaStop = 0xB2,
        //
        // Summary:
        //     The media play pause key (Windows 2000 or later).
        MediaPlayPause = 0xB3,
        //
        // Summary:
        //     The launch mail key (Windows 2000 or later).
        LaunchMail = 0xB4,
        //
        // Summary:
        //     The select media key (Windows 2000 or later).
        SelectMedia = 0xB5,
        //
        // Summary:
        //     The start application one key (Windows 2000 or later).
        LaunchApplication1 = 0xB6,
        //
        // Summary:
        //     The start application two key (Windows 2000 or later).
        LaunchApplication2 = 0xB7,
        //
        // Summary:
        //     The OEM Semicolon key on a US standard keyboard (Windows 2000 or later).
        OemSemicolon = 0xBA,
        //
        // Summary:
        //     The OEM 1 key.
        Oem1 = 0xBA,
        //
        // Summary:
        //     The OEM plus key on any country/region keyboard (Windows 2000 or later).
        Oemplus = 0xBB,
        //
        // Summary:
        //     The OEM comma key on any country/region keyboard (Windows 2000 or later).
        Oemcomma = 0xBC,
        //
        // Summary:
        //     The OEM minus key on any country/region keyboard (Windows 2000 or later).
        OemMinus = 0xBD,
        //
        // Summary:
        //     The OEM period key on any country/region keyboard (Windows 2000 or later).
        OemPeriod = 0xBE,
        //
        // Summary:
        //     The OEM question mark key on a US standard keyboard (Windows 2000 or later).
        OemQuestion = 0xBF,
        //
        // Summary:
        //     The OEM 2 key.
        Oem2 = 0xBF,
        //
        // Summary:
        //     The OEM tilde key on a US standard keyboard (Windows 2000 or later).
        Oemtilde = 0xC0,
        //
        // Summary:
        //     The OEM 3 key.
        Oem3 = 0xC0,
        //
        // Summary:
        //     The OEM open bracket key on a US standard keyboard (Windows 2000 or later).
        OemOpenBrackets = 0xDB,
        //
        // Summary:
        //     The OEM 4 key.
        Oem4 = 0xDB,
        //
        // Summary:
        //     The OEM pipe key on a US standard keyboard (Windows 2000 or later).
        OemPipe = 0xDC,
        //
        // Summary:
        //     The OEM 5 key.
        Oem5 = 0xDC,
        //
        // Summary:
        //     The OEM close bracket key on a US standard keyboard (Windows 2000 or later).
        OemCloseBrackets = 0xDD,
        //
        // Summary:
        //     The OEM 6 key.
        Oem6 = 0xDD,
        //
        // Summary:
        //     The OEM singled/double quote key on a US standard keyboard (Windows 2000 or later).
        OemQuotes = 0xDE,
        //
        // Summary:
        //     The OEM 7 key.
        Oem7 = 0xDE,
        //
        // Summary:
        //     The OEM 8 key.
        Oem8 = 0xDF,
        //
        // Summary:
        //     The OEM angle bracket or backslash key on the RT 102 key keyboard (Windows 2000
        //     or later).
        OemBackslash = 0xE2,
        //
        // Summary:
        //     The OEM 102 key.
        Oem102 = 0xE2,
        //
        // Summary:
        //     The PROCESS KEY key.
        ProcessKey = 0xE5,
        //
        // Summary:
        //     Used to pass Unicode characters as if they were keystrokes. The Packet key value
        //     is the low word of a 32-bit virtual-key value used for non-keyboard input methods.
        Packet = 0xE7,
        //
        // Summary:
        //     The ATTN key.
        Attn = 0xF6,
        //
        // Summary:
        //     The CRSEL key.
        Crsel = 0xF7,
        //
        // Summary:
        //     The EXSEL key.
        Exsel = 0xF8,
        //
        // Summary:
        //     The ERASE EOF key.
        EraseEof = 0xF9,
        //
        // Summary:
        //     The PLAY key.
        Play = 0xFA,
        //
        // Summary:
        //     The ZOOM key.
        Zoom = 0xFB,
        //
        // Summary:
        //     A constant reserved for future use.
        NoName = 0xFC,
        //
        // Summary:
        //     The PA1 key.
        Pa1 = 0xFD,
        //
        // Summary:
        //     The CLEAR key.
        OemClear = 0xFE,
        //
        // Summary:
        //     The SHIFT modifier key.
        Shift = 0x10000,
        //
        // Summary:
        //     The CTRL modifier key.
        Control = 0x20000,
        //
        // Summary:
        //     The ALT modifier key.
        Alt = 0x40000
    }
    #endregion

    #region MouseButtons enum
    //
    // Summary:
    //     Specifies constants that define which mouse button was pressed.

    public enum MouseButtons
    {
        //
        // Summary:
        //     The left mouse button was pressed.
        Left = 0x100000,
        //
        // Summary:
        //     No mouse button was pressed.
        None = 0x0,
        //
        // Summary:
        //     The right mouse button was pressed.
        Right = 0x200000,
        //
        // Summary:
        //     The middle mouse button was pressed.
        Middle = 0x400000,
        //
        // Summary:
        //     The first XButton was pressed.
        XButton1 = 0x800000,
        //
        // Summary:
        //     The second XButton was pressed.
        XButton2 = 0x1000000
    }
    #endregion


    public static class MouseKeyGlobalHelper
    {
        public static MouseButtons MouseButtonLookup(MouseButton mouseButton)
        {
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
        }

        public static MouseButton MouseButtonReverseLookup(MouseButtons mouseButton)
        {
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
        }

        // https://github.com/kwhat/libuiohook/blob/1.2/include/uiohook.h
        // https://sharphook.tolik.io/v5.0.0/articles/keycodes.html
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

                case KeyCode.VcKanji:
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
                    return KeyCode.VcKanji;

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