namespace algorithms_Datastructures.Search
{
    public static class Search
    {
        public static int SequentialSearch(this int[] sequence, int value)
        {
           for(int i=0; i<sequence.Length-1;i++){
               if(sequence[i] == value)return i;
           }
           return -1;
        }

        public static int BinarySearch(this int[] sequence, int value)
        {
            int low = 0;
            int high = sequence.Length-1;
            int middle;
            while(low <= high){
                middle = (low+high)/2;
                if(value < sequence[middle]){
                    high = middle-1;
                }else if (value > sequence[middle]){
                    low = middle +1;
                }else{
                    return middle;
                }
            }
            return -1;
        }
    }
}