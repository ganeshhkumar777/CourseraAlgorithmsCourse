using System;
namespace CourseEraDSA.Algorithms {
      class QuickUnion{
        protected int[] input;
        public QuickUnion(int count){
            input=new int[count];
            for(int i=0;i<input.Length;i++){
                input[i] = i;
            }
        }
        public void Union(int a, int b){
            var Left = a;
            var Right = b;
            var LeftRoot=Root(a);
            var RightRoot=Root(b);
            input[LeftRoot]=RightRoot;
        }
        private int Root(int a){

            if(input[a]==a){
                return a;
            } 
            input[a]=input[input[a]];
            return Root(input[a]);
        }
        public void Print(){
            for(int i=0;i<input.Length;i++){
                Console.Write(i+"\t");
            }
            Console.WriteLine("");
            for(int i=0;i<input.Length;i++){
                Console.Write(input[i]+"\t");
            }
        }
        public bool IsConnected(int a,int b) {
            var result= Root(a) == Root(b);
            Console.WriteLine(a+" & "+b+" are connected: "+result);
            return result;
        }
    }
}