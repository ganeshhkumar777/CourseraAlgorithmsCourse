namespace CourseEraDSA.Algorithms{
    class Percolation{
        int[,] grid;
        WeighedQuickUnion obj;
        int count;
        public Percolation(int n){
            count=n;
            obj =new WeighedQuickUnion(n*n);
            grid=new int[n,n];
        }

        public void open(int col, int row){
            grid[col,row]=1;
            int result=col*count+row;
            int[] neighbours=getNeighbors(col, row);
            foreach(var neighbour in neighbours){
                if(neighbour==0)continue;
                obj.Union(result,neighbour);
            }
            
        }

        private int[] getNeighbors(int col, int row){
            var temp=new int[9];
            var init=-1;
            for(var i=col-1; i<=col+1 && i<count;i++){   
                if(i<=-1)continue;
                for(var j=row-1; j<=row+1  && j < count ;j++){
                    if(j<=-1)continue;
                    if(grid[i,j]==1 &&( i!=col && j!=row)){
                        temp[++init]=i*count+j+1;   
                    }
                
                }
            }
            return temp;
        }

    
    }
}