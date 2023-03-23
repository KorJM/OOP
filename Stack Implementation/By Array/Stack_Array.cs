using System;
class Stack_Array
{
    static void Main(string[] args)
    {
        StackByArray<int> stack = new StackByArray<int>();
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

class StackByArray<T>
{
    private T[] items = new T[1];
    private int top = -1;  

    public void push(T item)
    {
        if (top == items.Length - 1)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        top++;
        items[top] = item;
    }

    public T pop()
    {
        try
        {
            T item = items[top];
            top--;
            return item;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Stack is Empty \nPrint default(T)");
            return default(T);
        }
    }

    public T peek()
    {
        try
        {
            return items[top];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Stack is Empty \nPrint default(T)");
            return default(T);
        }  
    }

    public bool isEmpty()
    {
        return top == -1;
    }

    public int size()
    {
        return top + 1;
    }
}
