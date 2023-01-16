// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// // (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16

// Console.Write("Введи число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введи число B: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A} в степени {B} равно {Getresult(A, B)}");
// int Getresult(int A, int B){
//     int result = 1;
//     for(int i = 1; i <= B; i++){
//         result = result * A;
//     }
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введи число: ");
// int number = int.Parse(Console.ReadLine()!);
// int lenght = NumberLen(number);
// Sumnumbers(number, lenght);

// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10; index++;
//     }
//     return index;
// }

// void Sumnumbers(int b, int lenght)
// {
//     int result1 = 0;
//     for (int i = 1; i <= lenght; i++)
//     {
//         result1 += b % 10;
//         b /= 10;
//     }
//     Console.WriteLine($"Cумма цифр в числе {number} равна {result1}");
// }


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// int[] Array = GetArray(8); 
// Console.Write($"[{String.Join(";", Array)}]"); 
 
// int[] GetArray (int size) 
// { 
//     int[] Array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         Array[i] = new Random().Next(8); 
//     } 
//     return Array; 
// }
