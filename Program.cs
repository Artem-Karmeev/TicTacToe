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

int[] array = new int[2];
int a = 0;
int x = array[0];
int y = array[1];



Console.WriteLine("Ходят x ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 1;
PrintImage(pic);

Console.WriteLine(pic[x, y]);
Console.WriteLine(array[1]);

Console.WriteLine("Ходят o ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 2;
PrintImage(pic);

Console.WriteLine(pic[x, y]);
Console.WriteLine(array[1]);

/*
Console.WriteLine("Ходят x ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 1;
PrintImage(pic);

Console.WriteLine("Ходят o ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 2;
PrintImage(pic);

Console.WriteLine("Ходят x ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 1;
PrintImage(pic);

Console.WriteLine("Ходят o ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 2;
PrintImage(pic);

Console.WriteLine("Ходят x ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 1;
PrintImage(pic);

Console.WriteLine("Ходят o ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 2;
PrintImage(pic);

Console.WriteLine("Ходят x ");
a = Convert.ToInt32(Console.ReadLine());
array = СonvertIndex(a);
pic[x, y] = 1;
PrintImage(pic);*/