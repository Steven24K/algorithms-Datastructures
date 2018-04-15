namespace algorithms_Datastructures.Sort
{
    using System;
    public static class Sort
    {
        static public void BubleSort(this int[] a){
        int temp;
        for (int i = 1; i < a.Length-1; i++){
            for(int j = 0; j < a.Length-1; j++){
                if(a[j+1] < a[j]){
                    temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                }
            }
          }
       }

        public static void InsertionSort(this int[] a)
        {
            int key;
            int temp_index;
            for(int current_index = 1; current_index < a.Length; current_index++)
            {
                key = a[current_index];
                temp_index = current_index-1;
                while(temp_index >= 0 && a[temp_index] > key){
                    a[temp_index+1] = a[temp_index];
                    temp_index -= 1;
                }
                a[temp_index+1] = key;
            }
        }

        private static void Merge(int[] a, int p, int q, int r)
        {
            int n1, n2, i, j;
            int[] L, R;

            n1 = q - p + 1;
            n2 = r - q;

            L = new int[n1 + 1];
            R = new int[n2 + 1];

            for (i = 0; i < n1; i++)
            {
                L[i] = a[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = a[q + 1 + j];
            }

            L[n1] = Int32.MaxValue;
            R[n2] = Int32.MaxValue;

            i = 0;
            j = 0;
            for (int k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i = i + 1;
                }
                else
                {
                    a[k] = R[j];
                    j = j + 1;
                }
            }
        }

        public static void MergeSort(this int[] a, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = (p + r) / 2;
                MergeSort(a, p, q);
                MergeSort(a, q + 1, r);

                Merge(a, p, q, r);
            }
        }

    }
}