using System;
namespace CourseEraDSA.Algorithms{
    public static class StackUsingLinkedListClient{
        public static void test(){
        var temp=new StackUsingLinkedList<string>();
        var currentText=Console.ReadLine();
        while(currentText!="stop"){
        if(currentText.Equals("-")){
            Console.WriteLine(temp.pop());
        } else {
            temp.push(currentText);
        }
        currentText=Console.ReadLine();

        }
        }
        
    }
}