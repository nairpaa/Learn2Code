using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

[DllImport(dllName:"kernel32", SetLastError = true)]
static extern nint OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

var hProcess = OpenProcess(dwDesiredAccess:0xF01FF, bInheritHandle:false, dwProcessId:26768);

if (hProcess == nint.Zero)
    Console.WriteLine("OpenPrroccess failed: {0}", Marshal.GetLastWin32Error());
else
{
    Console.WriteLine("hProcess: 0x{0}");
}