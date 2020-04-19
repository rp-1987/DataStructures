using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MinHeap
    {
        public int[] HeapArray { get; private set; }
        public int Capacity { get; private set; }
        public int HeapSize { get; private set; }
        public MinHeap(int capacity)
        {
            Capacity = capacity;
            HeapSize = 0;
            HeapArray = new int[capacity];
        }

        //To recursively MinHeapify a subtree
        public void MinHeapify(int rootIndex)
        {
            int left = GetLeftIndex(rootIndex);
            int right = GetRightIndex(rootIndex);
            int smallest = rootIndex;
            if (left < HeapSize && HeapArray[left] < HeapArray[rootIndex])
                smallest = left;
            if (right < HeapSize && HeapArray[right] < HeapArray[smallest])
                smallest = right;

            if(smallest != rootIndex)
            {
                SwapElements(rootIndex, smallest);
                MinHeapify(smallest);
            }
        }

        public int GetParentIndex(int i)
        {
            return (i - 1) / 2;
        }

        public int GetLeftIndex(int i)
        {
            return (2 * i + 1);
        }

        public int GetRightIndex(int i)
        {
            return (2 * i + 2);
        }

        // Method to remove minimum element (or root) from min heap 
        public int ExtractMin()
        {
            if (HeapSize == 0)
                throw new ArgumentNullException("Heap Is Empty");
            if(HeapSize == 1)
            {
                HeapSize--;
                return HeapArray[0];
            }

            int root = HeapArray[0];
            HeapArray[0] = HeapArray[HeapSize - 1];
            HeapSize--;
            MinHeapify(0);

            return root;
        }

        // Decreases value of key at index 'i' to new_val.  It is assumed that 
        // new_val is smaller than harr[i].
        public void DecreaseKey(int i, int newValue)
        {
            HeapArray[i] = newValue;
            while(i != 0 && HeapArray[GetParentIndex(i)] > HeapArray[i])
            {
                SwapElements(GetParentIndex(i), i);
                i = GetParentIndex(i);
            }
        }

        public int GetMin()
        {
            return HeapArray[0];
        }

        public void DeleteKey(int index)
        {
            DecreaseKey(index, Int32.MinValue);
            ExtractMin();
        }

        public void InsertKey(int key)
        {
            if (HeapSize >= Capacity)
                throw new StackOverflowException("Heap is full");
            int i = HeapSize;
            HeapArray[i] = key;
            HeapSize++;

            while(i != 0 && HeapArray[GetParentIndex(i)] > HeapArray[i])
            {
                SwapElements(GetParentIndex(i), i);
                i = GetParentIndex(i);
            }
        }

        private void SwapElements(int i, int j)
        {
            int temp = HeapArray[i];
            HeapArray[i] = HeapArray[j];
            HeapArray[j] = temp;
        }
    }
}
