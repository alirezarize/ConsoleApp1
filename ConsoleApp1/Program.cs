// Alireza Khosravi
// Mohsen Mohammadi

using System.Diagnostics;

void Sum(int a, int b) => Console.WriteLine(a+b);

String ConvertBack(byte[] inp) => new String(inp.Select(c => (char)Convert.ToChar(c)).ToArray());
byte[] ConvertToByte(String inp) => inp.Select(c=>(byte)c).ToArray();

int a = 0, b = 0;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

Sum(a, b);