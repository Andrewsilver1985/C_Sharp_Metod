int[,] Creat(int rowCount, int colCount)
{
    int[,] table = new int[rowCount, colCount];
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 1000);


        }
    }
    return table;

}

bool Interes(int value)
{
    int sumDig = GetSumOfDig(value);

    if (sumDig % 2 == 0)
        return true;
    else
        return false;


}
int GetSumOfDig(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;

    }
    return sum;
}

int[,] arr = Creat(3, 4);
    foreach (var item in arr)
    {
        if (Interes(item) == true)
        {
            System.Console.WriteLine($"{item} ");
        }
    }

