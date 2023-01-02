int [] array = {31, 22, 15, 56, 78, 63, 41, 37};

int n = array.Length;
int find = 41;
int index = 0;

while (index < n) {
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
    index++;
}