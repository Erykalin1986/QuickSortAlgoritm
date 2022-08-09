int[] inputaArray = { 9, 12, 9, 2, 17, 1, 6 };

int[] sortedArray = QuickSort(inputaArray, 0, inputaArray.Length - 1);

Console.WriteLine($"Sorted array: {string.Join(",", sortedArray)}");
Console.ReadLine();

static int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return array;

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);

    return pivot;
}

static void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}