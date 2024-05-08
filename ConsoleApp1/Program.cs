// Alireza Khosravi
// Mohsen Mohammadi

using System.Diagnostics;

void Sum(int a, int b) => Console.WriteLine(a+b);
String ConvertBack(byte[] inp)
{
    String result = "";
    for (int i = 0; i < inp.Length; i++)
    {
        result += (char)inp[i];
    }

    return result;
}

byte[] ConvertToByte(String inp)
{
    List<byte> b = new List<byte>();
    for(int i = 0; i < inp.Length; i++)
    {
        b.Add((byte)inp[i]);
    }

    return b.ToArray();
}

int a = 0, b = 0;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

Sum(a, b);