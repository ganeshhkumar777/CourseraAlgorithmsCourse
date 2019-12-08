namespace CourseEraDSA.Algorithms{
     class WeighedQuickUnionFind: WeighedQuickUnion{
        protected int[] max;        
       public WeighedQuickUnionFind(int count) : base(count){            
            max=new int[count];
              for(int i=0;i<input.Length;i++){
                max[i] = i;
            }
        }
        public override void Union(int a, int b){
            var LeftRoot=Root(a);
            var RightRoot=Root(b);
            var maximum = max[LeftRoot] > max[RightRoot]? max[LeftRoot]:max[RightRoot];
            if(depth[LeftRoot]<=depth[RightRoot]){
                //left is a smaller tree as compared to Right.Hence joining left tree to right
                max[RightRoot]=maximum;
                input[LeftRoot]=RightRoot;
                if(depth[RightRoot]+1>depth[LeftRoot]){
                    depth[RightRoot]=depth[LeftRoot]+1;
                }    

            } else{
                max[LeftRoot]=maximum;
                input[RightRoot]=LeftRoot;
                if(depth[LeftRoot]+1>depth[RightRoot]){
                    depth[LeftRoot]=depth[RightRoot]+1;
                }    
            }
            
        }
        public int find(int i){
            var root=Root(i);
            return max[root];
        }
        public void PrintMaxArray(){
            Print(max);
        }
    }
}