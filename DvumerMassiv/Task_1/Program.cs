
int[,] Creat(int rowCount, int colCount)
{
    int[,] table = new int[rowCount, colCount];
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);


        }
    }
    return table;
}

void ShowTable(int[,] table)
{
    Random rnd=new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
            System.Console.Write($"{table[i, j]} ");


        }
        System.Console.WriteLine();
    }
}
ShowTable(Creat(4,6));
