using System;
namespace CourseEraDSA.Algorithms{
    public class StackUsingLinkedList<T>{
        public Node<T> head;
        private int length{get;set;}
        public StackUsingLinkedList(){
            head=null;
            length=-1;
        }
        public void push(T input){
            var current=new Node<T>();
            current.data=input;
            current.next=head;
            head=current;
            length++;
        }
        public T pop(){
            if(isEmpty()){
                throw new ArgumentException("length of the stack is zero.");
            }
            var current=head;
            head=current.next;
            length--;
            return current.data;
        }

        public bool isEmpty(){
            return length==-1;
        }

        public class Node<T1>{
            public T1 data;
            public Node<T1> next;
        }
    }

    

}