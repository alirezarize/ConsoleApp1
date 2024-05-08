using System.Diagnostics;

// Alireza Khosravi
// Mohsen Mohammadi
// Mohammad Ashrafi
/// <summary>
/// aaa
/// </summary>

String ConvertBack(byte[] inp) => new String(inp.Select(c => (char)Convert.ToChar(c)).ToArray());
byte[] ConvertToByte(String inp) => inp.Select(c => (byte)c).ToArray();

int a = 0, b = 0;

Console.Write("First Number : ");
int.TryParse(Console.ReadLine(), out a);

Console.Write("Second Number : ");
int.TryParse(Console.ReadLine(), out b);

MethodInvoker(new List<Func<int, int, Tuple<string, int>>>()
{
    new Func<int, int, Tuple<string,int>>((int a, int b) =>
    {
        return Tuple.Create("Zarb",a * b);
    }),
    new Func<int, int, Tuple<string,int>>((int a, int b) =>
    {
        return Tuple.Create("Taghsim ",a / b);
    }),
    new Func<int, int,  Tuple<string,int>>((int a, int b) =>
    {
       return Tuple.Create("Plus ",a + b);
    }),
    new Func<int, int,  Tuple<string,int>>((int a, int b) =>
    {
        return Tuple.Create("Menha ",a - b);
    }),
}, a, b);

void MethodInvoker(List<Func<int, int, Tuple<string, int>>> methods, int inp1, int inp2)
{
    foreach (var method in methods)
        Console.WriteLine(method(inp1, inp2));
}

class Student
{
    public int Id { get; private set; }
    public String Username { get; set; }
    public UInt32 PPP { get; set; }
}