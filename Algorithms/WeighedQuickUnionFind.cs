namespace CourseEraDSA.Algorithms{
    class WeighedQuickUnionFind: WeighedQuickUnion{
        private int[] Max;
        WeighedQuickUnionFind(int count) : base(count){            
            Max=new int[count];
        }
        public void find() {
            
        }
    }
}