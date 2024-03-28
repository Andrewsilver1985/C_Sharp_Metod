Random rnd =new Random();
int size = 1000;
int [] arr =new int[size];
int i=0;
while (i<1000)
{
    arr[i]=rnd.Next(1, 10);
    System.Console.Write($"{arr[i]} ");
    i++;
}
