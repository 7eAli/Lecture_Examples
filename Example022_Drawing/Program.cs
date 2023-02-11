﻿void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[rows, columns]} ");
            if(image[i, j] == 0) Console.Write("  ");
            else Console.Write($"+ ");
        }
        Console.WriteLine();
    }
}



int[,] pic = new int[,]
{
    {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
    {1, 1, 0, 1, 0, 0, 0, 0, 0, 0},
    {1, 0, 1, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {1, 0, 0, 1, 1, 1, 0, 0, 0, 0},
    {1, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    {1, 0, 1, 0, 1, 1, 1, 0, 0, 0},
    {1, 0, 1, 0, 0, 1, 1, 0, 0, 0},
    {1, 0, 1, 0, 0, 1, 1, 1, 0, 1},
    {1, 1, 0, 0, 1, 1, 1, 1, 1, 1}
};
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
Console.WriteLine();
FillImage(4, 1);
PrintImage(pic);


