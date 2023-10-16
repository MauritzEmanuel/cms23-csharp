using System.Runtime.InteropServices;

namespace _02_Structs.Structs.Interoperability;

//Till för att tala mellan olika språk
[StructLayout(LayoutKind.Sequential)]
public struct Todo
{
    public int userId;
    public int id;
    public string title;
    public bool completed;
}
