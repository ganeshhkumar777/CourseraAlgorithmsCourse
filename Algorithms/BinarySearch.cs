namespace CourseEraDSA.Algorithms{
    class BinarySearch {
        int[] input;
        int currentIndex=0;
        public BinarySearch(int count){
            input=new int[count];
        }
        public void AddItem(int i){
            input[currentIndex]=i;
            currentIndex++;
        }

        public int Find(int i){
            return IndexOf(i,0, input.Length-1);
        }

        public int IndexOf(int i, int from, int to){
            
            var middle=(from+to)/2;
            if(input[middle]==i){
                return middle;
            } 
            if(from == to){
                return -1;
            }
            if(input[middle]<i){
                return IndexOf( i, middle+1, to);
            }  
                return IndexOf( i, from,middle-1);
            
        }
    }
}