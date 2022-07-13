int[] array = {11, 32, 23, 18, 35, 16, 27, 18};

int n = array.Length;
int find = 18;

int i = 0;

while (i < n)
{

    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i= i + 1;
}
