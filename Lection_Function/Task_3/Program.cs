// See https://aka.ms/new-console-template for more information
int[] arr = { 1, 2, 3, 4, 5, 6 };
void Zero(int[] arr)
{
    for (int i = 0; i < 6; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;

        }
        System.Console.WriteLine(arr[i]);
    }

}
Zero(arr);