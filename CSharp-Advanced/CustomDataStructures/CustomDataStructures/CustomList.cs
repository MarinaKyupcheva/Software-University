﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

       public int this[int index]
        {
            get
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int [this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(int item)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;

        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count-1 ; i++)
            {
                this.items[i] = this.items[i + 1];
            }

           this.items[this.Count - 1] = default;
        //   for (int i = this.Count-1; i < this.items.Length; i++)
        //   {
        //       this.items[i] = default;
        //   }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public int RemoveAt(int index)
        {
            if(index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);

            this.Count--;

            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i < index; i++)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        public void Insert(int index, int element)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;

        }

       public bool Contains(int element)
       {
          
           for (int i = 0; i < this.Count; i++)
           {
               if(this.items[i] == element)
               {
                   return true;
               }
              
           }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if(firstIndex > Count || secondIndex > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

         var elementFirstIndex = this.items[firstIndex];
         this.items[firstIndex] = this.items[secondIndex];
         this.items[secondIndex] = elementFirstIndex;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if(i == this.Count - 1)
                {
                    sb.Append($"{this.items[i]}");
                }
                else
                {
                    sb.Append($"{this.items[i]}, ");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
