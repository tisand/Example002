

void FillArray(int[] collection)
    {
        int lenght = collection.Length;
        int index = 0;
        while(index < lenght)
        {
            collection[index] = new Random().Next(1,10); 
            index++;
        }
    }

void PrintArray (int[] col) 
{
    int count = col.Length;
    int possition = 0;
    while (possition < count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index= 0;
    int possition = -1;
    
    while (index < count)
    {
        if (collection[index] == find)
        {
            possition = index;
            break;
        }
        index++;
    }
    return possition; 
}

int [] array = new int [10];

FillArray(array);

PrintArray(array); 

Console.WriteLine();

int pos = IndexOf(array, 7);
Console.WriteLine(pos); 



