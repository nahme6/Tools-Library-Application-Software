namespace Tools_Library_Application_Software
{
    internal class HeapSortBase
    {
        public static void HeapSort(Tool[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Tool temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        static void heapify(Tool[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left].NoBorrowings > arr[largest].NoBorrowings)
                largest = left;
            if (right < n && arr[right].NoBorrowings > arr[largest].NoBorrowings)
                largest = right;
            if (largest != i)
            {
                Tool swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
    }
}