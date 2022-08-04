/*
Написать программу, которая из имеющегося массива строкформирует массив из строк, 
длинна которых меньше либо равна 3 символам. Первоначальный массив можно вывести 
с помощью клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

{"Hello", "2", "word", ":)"} -> {"2",":-)"}
{"1234", "1567", "-2", "computer science"} -> {"-2"}
{"Russia", "Denmark", "Kazan"} -> {}

*/

namespace ChoosingASpecialization
{
    class FinalTask
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[]
                        {"Hello", "2", "word", ":-)"}
                        // {"1234", "1567", "-2", "computer science"}
                        // {"Russia", "Denmark", "Kazan"}
            ;
            string[] array2 = new string[array1.Length];
            FillStringArray(array1, array2);
            PrintArray(array2);

            void FillStringArray(string[] array1, string[] array2)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length <= 3)
                    {
                        array2[i] = array1[i];
                    }
                }
            }
            
            void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
           
        }
    }
}