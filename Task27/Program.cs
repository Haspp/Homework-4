Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

// while(N > 9)
// {
//     sum = sum + N % 10;
//     N = N / 10;
// }
// sum = sum + N;

// Console.WriteLine("Сумма чисел равна: " + sum);


// for(; N > 9; )
// {
//     sum = sum + N % 10;
//     N = N / 10;
// }
// sum = sum + N;
// Console.WriteLine("Сумма чисел равна: " + sum);


do 
{
    sum = sum + N % 10;
    N = N / 10;
}
while(N > 9);
sum = sum + N;
Console.WriteLine("Сумма чисел равна: " + sum);
