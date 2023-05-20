using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

[DllImport(dllName:"kernel32", SetLastError = true)]
static extern nint LoadLibraryW (
    [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);

var hProcess = LoadLibraryW(lpLibFileName:"amsi.dll");using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

[DllImport(dllName:"kernel32", SetLastError = true)]
static extern nint LoadLibraryW (
    [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);

var hProcess = LoadLibraryW(lpLibFileName:"amsi.dll");