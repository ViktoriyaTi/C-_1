int[] array = {1,2,1,141,5,6,7,14,14,14};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
