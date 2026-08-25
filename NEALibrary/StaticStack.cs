using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class StaticStack<T> // the <T> means we will be using the Generic data type
    {
        private int MaxSize;
        private int StackPointer = -1;
        private T[] Item;

        public StaticStack(int maxsize)
        {
            MaxSize = maxsize;
            Item = new T[MaxSize];

        }
        public bool IsFull()
        {
            return (StackPointer == MaxSize - 1);
        }

        public bool IsEmpty()
        {

            return StackPointer == -1;
        }

        public void Push(T value)
        {
            if (!IsFull())
            {
                StackPointer++;
                Item[StackPointer] = value;

            }
            else
            {
                throw new InvalidOperationException("Stack overflow error");
                
            }
                

        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow error");
                
            }

            else
            {
                StackPointer--;
                return Item[StackPointer + 1];
            }
                
        }


        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow error");
                
            }
            else
            {
                return Item[StackPointer];
            }
        }

        public int GetSize()
        {
            return StackPointer + 1;
        }

        public List<T> GetList()
        {
            List<T> list = new List<T>();
            for (int i = 0; i <= StackPointer; i++)
            {
                list.Add(Item[i]);
            }
            return list;
        }
    }
    

    

}
