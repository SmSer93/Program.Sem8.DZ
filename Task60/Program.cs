// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

void PrintArrya(int[,,] arg)  
{
    for (int i = 0; i < arg.GetLength(0); i++) 
    {
        for (int j = 0; j < arg.GetLength(1); j++) 
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                Console.Write($" {arg[i, j, k]} - {(i, j, k)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArrya(int[,,] arg)
{
    int[] repeat = new int[arg.GetLength(0) * arg.GetLength(1) * arg.GetLength(2)]; 
    int cout = 0; // счетчик

    for (int i = 0; i < arg.GetLength(0); i++) 
    {
        for (int j = 0; j < arg.GetLength(1); j++)  
        {
            for (int k = 0; k < arg.GetLength(2);)
            {
                repeat[cout] = new Random().Next(10, 100);  
                bool checkRepeat = true;  

                for (int l = 0; l < cout; l++) 
                {
                    if (repeat[cout] == repeat[l]) 
                    {
                        checkRepeat = false; 
                        repeat[cout] = 0;  
                        break;             
                    }
                }
                if (checkRepeat)  
                {
                    arg[i, j, k] = repeat[cout]; 
                    cout++;
                    k++;
                }

            }
        }
    }


}


Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину глубины ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[row, colums, depth];

FillArrya(arr);
PrintArrya(arr);