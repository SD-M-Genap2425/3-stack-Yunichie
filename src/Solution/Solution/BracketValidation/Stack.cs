using System.IO;

namespace Solution.BracketValidation
{
    public class StackNode
    {
        public char data;
        public StackNode next;

        public StackNode(char data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class Stack
    {
        private StackNode top;

        public Stack()
        {
            this.top = null;
        }

        public void Push(char item)
        {
            StackNode newNode = new StackNode(item);
            newNode.next = top;
            top = newNode;
        }

        public char Pop()
        {
            if (top == null) return ' ';
            else
            {
                char item = top.data;
                top = top.next;
                return item;
            }
        }

        public char Peek()
        {
            if (top == null) return ' ';
            else return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}