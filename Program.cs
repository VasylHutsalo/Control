// Контрольная работа
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символам.
//Превоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.




void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{matr[i]}, ");
    }
    Console.WriteLine();
}

void Arra(string[] sel)
{
    int count = sel.Length;
    if (sel is null) return;
    {
        Console.WriteLine($" -->[]");
    }
    if (sel is not null)

    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"-->[{sel[i]}]");

            for (int j = 0; j < count; j++)
            {
                Console.WriteLine($"-->[{sel[i]}, {sel[j]}] ");

                for (int k = 0; k < count; k++)
                {
                    Console.WriteLine($"-->[{sel[i]}, {sel[j]}, {sel[k]}]");
                }
            }
        }
    }
}
string[] arr = { "hello", "123", "^%", "rew" };
PrintArray(arr);
Console.WriteLine();
Arra(arr);



