void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i,j] == 1) Console.Write($"x");
            if(image[i,j] == 2) Console.Write($"o");
            if(image[i,j] == 0) Console.Write($"_");
        }
        Console.WriteLine();
    }
}

int[] СonvertIndex(int a)
{
    int[] array = new int[2];

    if (a == 7) array[0] = 0; array[1] = 0;
    if (a == 8) array[0] = 0; array[1] = 1;
    if (a == 9) array[0] = 0; array[1] = 2;
    if (a == 4) array[0] = 1; array[1] = 0;
    if (a == 5) array[0] = 1; array[1] = 1;
    if (a == 6) array[0] = 1; array[1] = 2;
    if (a == 1) array[0] = 2; array[1] = 0;
    if (a == 2) array[0] = 2; array[1] = 1;
    if (a == 3) array[0] = 2; array[1] = 2;
    
    return array;
}

int[,] pic = new int[3, 3];

//int[] array = new int[2];
//int a = 0;
//int x = 0; 
//int y = 0; 



Console.WriteLine("Ходят x ");
int a1 = Convert.ToInt32(Console.ReadLine());
int[] array1 = СonvertIndex(a1);
int x1 = array1[0];
int y1 = array1[1];
pic[x1, y1] = 1;
PrintImage(pic);

Console.WriteLine(pic[x1, y1]);
Console.WriteLine($"{array1[0]}, {array1[1]}");

/*Console.WriteLine("Ходят o ");
int a2 = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a2);
int x2 = array[0];
int y2 = array[1];
pic[x2, y2] = 2;
PrintImage(pic);

Console.WriteLine(pic[x2, y2]);
Console.WriteLine($"{array[0]}, {array[1]}");*/

