using System;
using System.Linq;

public class ArraySESS
{
    // Метод сортировки массива по возрастанию
    public static int[] SortAscending(int[] arr)
    {
        return arr.OrderBy(x => x).ToArray();
    }

    // Метод сортировки массива по убыванию
    public static int[] SortDescending(int[] arr)
    {
        return arr.OrderByDescending(x => x).ToArray();
    }

    // Метод объединения двух массивов в один
    public static int[] ConcatenateArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }
}
