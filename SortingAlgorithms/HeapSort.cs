namespace SortingAlgorithms
{
    public class HeapSort
    {
        public int[] SortArray(int[] unsortedArray)
        {
            int arrayLength = unsortedArray.Length;
            for (int i = ((arrayLength / 2) - 1); i >= 0; i--)
            {
                Heapify(unsortedArray, arrayLength, i);
            }

            for (int i = (arrayLength - 1); i >= 0; i--)
            {
                int temp = unsortedArray[0];
                unsortedArray[0] = unsortedArray[i];
                unsortedArray[i] = temp;

                Heapify(unsortedArray, i, 0);
            }

            return unsortedArray;
        }

        private void Heapify(int[] array, int heapSize, int index)
        {
            int largest = index;
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

            if (leftChildIndex < heapSize && array[leftChildIndex] > array[largest])
                largest = leftChildIndex;
            if (rightChildIndex < heapSize && array[rightChildIndex] > array[largest])
                largest = rightChildIndex;

            if (largest != index)
            {
                int temp = array[index];
                array[index] = array[largest];
                array[largest] = temp;

                Heapify(array, heapSize, largest);
            }
        }
    }
}
