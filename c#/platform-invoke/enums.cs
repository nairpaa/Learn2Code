using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

[DllImport(dllName:"kernel32", SetLastError = true)]
static extern nint OpenProcess(ProcessAccessRights dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

var hProcess = OpenProcess(
    dwDesiredAccess:ProcessAccessRights.PROCESS_VM_READ | ProcessAccessRights.PROCESS_VM_READ,
    bInheritHandle:false, dwProcessId:2676668);


[Flags]
internal enum ProcessAccessRights : uint
{
    // many missing for vrevity
    PROCESS_VM_READ = 0x0010,
    PROCESS_VM_WRITE = 0x0020,
    PROCESS_VM_OPERATION = 0x0008
}