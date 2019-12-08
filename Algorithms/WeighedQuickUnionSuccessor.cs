using System;
namespace  CourseEraDSA.Algorithms {
public class WeighedQuickUnionSuccessor{
        protected int[] input;
        protected int[] depth;
        public WeighedQuickUnionSuccessor(int count){
            input=new int[count];
            depth=new int[count];
            for(int i=0;i<input.Length;i++){
                input[i] = i;
                depth[i] = 0;
            }
        }
        public void Union(int a, int b){
            var LeftRoot=Root(a);
            var RightRoot=Root(b);
            if(depth[LeftRoot]<=depth[RightRoot]){
                //left is a smaller tree as compared to Right.Hence joining left tree to right
                input[LeftRoot]=RightRoot;
                if(depth[RightRoot]+1>depth[LeftRoot]){
                    depth[RightRoot]=depth[LeftRoot]+1;
                }    

            } else{
                input[RightRoot]=LeftRoot;
                if(depth[LeftRoot]+1>depth[RightRoot]){
                    depth[LeftRoot]=depth[RightRoot]+1;
                }    
            }
            
        }
        private int Root(int a){

            if(input[a]==a){
                return a;
            } 
            return Root(input[a]);
        }
        public void Print(int[] inp){
            Console.WriteLine("");
            for(int i=0;i<inp.Length;i++){
                Console.Write(i+"\t");
            }
            Console.WriteLine("");
            for(int i=0;i<inp.Length;i++){
                Console.Write(inp[i]+"\t");
            }
        }

        public void PrintInput(){
            Print(input);
        }
        public void PrintDepth(){
            Print(depth);
        }
        public bool IsConnected(int a,int b) {
            var result= Root(a) == Root(b);
            Console.WriteLine(a+" & "+b+" are connected: "+result);
            return result;
        }

}

}