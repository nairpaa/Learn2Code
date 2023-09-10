using System.Runtime.InteropServices;

[DllImport("kernel32", SetLastError = true)]
static extern nint OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

var hProcess = OpenProcess(0xF01FF, false, 26768);

if (hProcess == nint.Zero)
    Console.WriteLine("OpenProcess failed {0}", Marshal.GetLastWin32Error());
else
    Console.WriteLine("hProcess: 0x{0}", hProcess);