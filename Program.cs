/* Задача: Написать программу, которая из имеющегося массива
строк формирует массив из строк, длина которых меньше либо
равна 3 символа. Первоначальный массив можно ввести
с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */


void methodArray (string [] array)
{
     string[] mass1 = new string[array.Length];
     for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
        mass1[i]=array[i];;
        Console.WriteLine(mass1[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array){
    for (int i=0; i<Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

methodArray(array);
Print(array);
