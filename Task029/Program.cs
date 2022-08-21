// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] createArray()
{
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 100);
    return array;
}

var array = createArray();
Console.Write("[" + array[0] + "," 
                + array[1] + ","  
                + array[2] + ","  
                + array[3] + ","   
                + array[4] + ","                     
                + array[5] + ","
                + array[6] + ","
                + array[7] + "]");