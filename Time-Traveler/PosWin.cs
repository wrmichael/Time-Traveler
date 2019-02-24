using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices; // For the P/Invoke signatures.

public static class PositionWindow
{

    // P/Invoke declarations.

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);



    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    const uint SWP_NOSIZE = 0x0001;
    const uint SWP_NOZORDER = 0x0004;

    public struct Rect
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }


    public static Rect getpos(String AppName)
    {

        Process[] processes = Process.GetProcessesByName(AppName);
        Process lol = processes[0];
        IntPtr ptr = lol.MainWindowHandle;
        Rect NotepadRect = new Rect();
        GetWindowRect(ptr, ref NotepadRect);
        return NotepadRect;


        /*
    // Find (the first-in-Z-order) Notepad window.
    IntPtr hWnd = FindWindow("Notepad", null);

        // If found, position it.
        if (hWnd != IntPtr.Zero)
        {
            // Move the window to (0,0) without changing its size or position
            // in the Z order.
            SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOZORDER);
        }
        */
    }

}


namespace ComPortPTT
{
    class PosWin
    {
    }
}


namespace Time_Traveler
{
    class PosWin
    {
    }
}
