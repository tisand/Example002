int Max (int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//     индекс = 0, 1, 2, 3, 4, 5, 6, 7, 8
int [] array = {51,22,63,74,25,26,67,88,19};
// array [0] = 31;
// Console.WriteLine(array[0]);

int max  = Max(
    Max(array[0], array[1], array[2]),
    Max(array[4], array[5], array[6]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);

// int a1 = 21;
// int b1 = 51;
// int c1 = 43;
// int a2 = 19;
// int b2 = 77;
// int c2 = 61;
// int a3 = 11;
// int b3 = 32;
// int c3 = 27;

// int max1 = Max (a1, b1 ,c1);
// int max2 = Max (a2, b2 ,c2);
// int max3 = Max (a3, b3 ,c3);
// int max = Max (max1, max2, max3);

// int max = Max (Max(a1, b1 ,c1), Max(a2, b2 ,c2), Max(a3, b3 ,c3));
// Console.WriteLine(max);

// if(b1 > max) max = b1; 
// if(c1 > max) max = c1; 
// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;
// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;      





