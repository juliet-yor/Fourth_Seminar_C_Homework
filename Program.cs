// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int GetMult(int mult){ 
//      int i = 1;
//      int c = a;
//     while ( i < b){
//         c = c * a;
//         i++;
//     }
//     return c;
// }
// Console.WriteLine($"{a} в {b} степени -> {GetMult(a)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int SumDigist(int number){               
//     int counter = 0;
//     int sum = 0;
//     int a = 0;
//     while (number > 0){
//         a = number % 10;
//         number = number / 10;
//         sum = sum + a;
//         counter++;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма цифр в числе {n} -> {SumDigist(n)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int [] GetArray(){
//     int [] result = new int [8];
//     for (int i = 0; i < result.Length; i++){
//         result[i] = new Random().Next(0, 99);
//     }
//     return result;
// }
// void PrintArray(int [] arr){
//     for (int i = 0; i < arr.Length; i++){
//       Console.Write($"{arr[i]} ");  
// }
// }
// PrintArray(GetArray());