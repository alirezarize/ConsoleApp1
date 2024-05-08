// Alireza Khosravi
// Mohsen Mohammadi
void Sum(int a, int b) => Console.WriteLine(a+b);


int a = 0, b = 0;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

Sum(a, b);