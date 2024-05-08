// Alireza Khosravi
// Mohsen Mohammadi

using System.Diagnostics;

String ConvertBack(byte[] inp) => new String(inp.Select(c => (char)Convert.ToChar(c)).ToArray());
byte[] ConvertToByte(String inp) => inp.Select(c=>(byte)c).ToArray();

int a = 0, b = 0;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

MethodInvoker(new List<Func<int, int, int>>()
{
    new Func<int, int, int>((int a, int b) =>
    {
        return a * b;
    }),
    new Func<int, int, int>((int a, int b) =>
    {
        return a / b;
    }),
    new Func<int, int, int>((int a, int b) =>
    {
        return a + b;
    }),
    new Func<int, int, int>((int a, int b) =>
    {
        return a - b;
    }),
    new Func<int, int, int>((int a, int b) =>
    {
        return (int)Math.Pow(a, b);
    })
}, a, b);

void MethodInvoker(List<Func<int, int, int>> methods, int inp1, int inp2)
{
    foreach(var method in methods)
        Console.WriteLine(method(inp1, inp2));
}

class Student
{
    public int Id { get; private set; }
    public String Username { get; set; }
    public UInt32 PPP { get; set; }
}