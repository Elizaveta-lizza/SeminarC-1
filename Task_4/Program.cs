Console.WriteLine("Введите три числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int Max = Convert.ToInt32(Console.ReadLine());
 
 if (A >= Max)
 {
Max = A;
 }
 if (B >= Max)
 {
    Max = B;
 }

Console.WriteLine($"Max: {Max}");