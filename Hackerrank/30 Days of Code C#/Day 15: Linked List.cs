using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)
	{
      Node N1 = new Node(data);
      if(head==null)
      {     head=N1;    }
      else   
       {
          if (head.next == null) 
            {
                head.next = N1;
            }
            else
             {
                Node current = head;
                while (current.next != null) 
                {
                    current = current.next;
                }
                current.next = N1;
       }
       }
       return head;
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	
