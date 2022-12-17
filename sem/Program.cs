// [1,40,20,30] => 30,800
// Задача 37* дз - складываем числа в цикле (скалярное сложение)

// int[] startArray = { 1, 2, 3, 4, 5 };
// int size = startArray.Length / 2; // 2 + 0/1
// Console.WriteLine(size);
// int[] result = new int[size];


// int first = 0; // Первый элемент из массива startArray
// int last = startArray.Length - 1; // 4 - индекс последнего элемента
// int i = 0; // Индекс результирующего массива

// while (last > first)
// {
//     result[i] = startArray[first] * startArray[last];
//     i++; //  result[0],  result[1]
//     first++;
//     last--;
// }
// Console.WriteLine(String.Join(", ", result));





// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] tempArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         tempArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return tempArray;
// }
// int[] array = GetArray(6, 0, 10); // Массив на 6 элементов от 0 до 10

// // 1. Запись массива справо - налево
// int[] CopyReverseArray(int[] array)
// {
//     int size = array.Length; 
//     int[] result = new int[size]; // Копия - такой же размер
//     int last = size - 1;
//     for (int i = 0; i < size; i++) // i++ - слево - направо
//     {
//         result[i] = array[last - i]; // Последний элемент - текущий
//     }
//     return result;
// }
// Console.WriteLine(String.Join("; ", array));

// Console.WriteLine(String.Join(", ", CopyReverseArray(array)));





// 2. Метод пузырька

// void BubbleSort(int[] array)
// {
//     int size = array.Length;
//     int last = size - 1;
//     for (int i = 0; i < size / 2; i++) // 5 / 2 = 2, 1 человек будет без пары
//     {
//         // a = {1,2,3,4}
//         int temp = array[i]; // temp = a[0], temp = 1 
//         array[i] = array[last - i]; // a[0] = a[3] => {4,2,3,4}
//         array[last - i] = temp; // temp = 1, a[3] = 1 => {4,2,3,1}
//     }
// }

// BubbleSort(array);
// Console.WriteLine($"Bubble: {String.Join(", ", array)}");





// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// bool IsTriangle(int a, int b, int c) // 3 стороны треугольника: а,b,c
// {
//     return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));  // True, False
// }
// Console.WriteLine(IsTriangle(100000,3,4));





// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int firstElement = 0;
// int secondElement = 1;
// int number = 8; // Количество чисел Фибоначчи: 0,1,1,2

// Console.WriteLine($"1 элемент. {firstElement}");
// Console.WriteLine($"2 элемент. {secondElement}");

// for (int i = 3; i <= number; i++)
// {
//     int nextElement = firstElement + secondElement; //next = 1
//     Console.WriteLine($"{i} элемент. {nextElement}");
//     firstElement = secondElement;
//     secondElement = nextElement;
// }






