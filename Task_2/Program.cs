Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int Min;
int Max;
 
 if (A >= B)
 {
Min = B;
Max = A;
 }
 else
 {
    Max = B;
    Min = A;
 }

Console.WriteLine($"Min: {Min} Max: {Max}");

