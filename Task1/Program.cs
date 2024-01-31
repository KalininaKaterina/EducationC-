int[] arr = new int[5];
arr[0] = 5;
arr[1] = 6;
arr[2] = 8;
arr[3] = 2;
arr[4] = 10;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

// Console.WriteLine(arr[5]);
// Первый способ создания фиксированного массива
int[] arr2 = new int[5] { 2, 5, 6, 3, 7 };

//  Второй способ создания фиксированного массива без 
// указания его размерности.
int[] arr3 = { 1, 5, 7, 3, 9 };

// arr = [1,3,6,2,8]