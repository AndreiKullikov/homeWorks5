// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// System.Console.WriteLine("введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());


// int [] array= new int[num];
// int count = 0;
// FillArrayRandomarray(array);
// void FillArrayRandomarray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] =new Random().Next(100,1000);
//     Console.Write(array[i]+" ");
// }   
    
// }
    
//    for (int z = 0; z < array.Length; z++)
//    if (array[z] % 2 == 0)
//        count++;
  

//    System.Console.WriteLine(count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// System.Console.WriteLine("введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array= new int[num];
// int count = 0;
// Fillarray(array);

// for (int j = 1; j < array.Length; j+=2)
//     count = count + array[j];

//     Console.WriteLine($"Cумма элементов на нечётных позициях = {count}");

// void Fillarray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//     array[i] =new Random().Next(1,10);
//     Console.Write(array[i]+" ");
//  } 

// }




// Задача 38: Задайте массив вещественных чисел. Найди
// те разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива:");
// int n = Convert.ToInt32(Console.ReadLine()); 
// double [] array  = new double[n];  

// for (int i = 0; i < array.Length; i++)
// {
// array[i] =Convert.ToDouble(new Random().Next(100,1000)) / 100;
// Console.Write(array[i]+" ");
// }
// double min = 100000;
// double max = 0;
// for (int z = 0; z < array.Length; z++)
// {
//     if (array[z] > max)
//         {
//             max = array[z];
//         }
//     if (array[z] < min)
//         {
//             min = array[z];
//         }
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

