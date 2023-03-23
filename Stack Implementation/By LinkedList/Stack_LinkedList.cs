using System;
    public class Stack_LinkedList
    {
        static void main(string[] args)
        {
            StackByLinkedList<int> stack = new StackByLinkedList<int>();

            stack.push(3);
            stack.push(2);
            stack.push(1);

            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.peek());
        }
    }

    class StackByLinkedList<T>
    {
        private LinkedList<T> stack = new LinkedList<T>();

        public void push(T value)
        {
            stack.AddFirst(value);
        }

        public T pop()
        {
            try
            {         
                T value = stack.First.Value;
                stack.RemoveFirst();
                return value;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Stack is Empty \nPrint default(T)");
                return default(T);
            }
        }

        public T peek()
        {
            try
            {
                return stack.First.Value;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Stack is Empty \nPrint default(T)");
                return default(T);
            }
        }
        
        public int count() { return stack.Count(); }

        public bool isEmpty() { return stack.Count() == 0; }

        public void clear() { stack.Clear(); }
    }



