using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CircularList // односвязный кольцевой список
{
    public class LinkedList<T> : IEnumerable 
    {
        public Item<T> First { get; private set; } // при необходимости сможем открыть и посмотреть какой элемент голова, но не даём возможности писать в него что-то извне.
        public Item<T> Last { get; private set; }
        public int Count { get; private set; } // можем считать кол-во элементов

        public LinkedList() // конструктор
        {
            Clear();
        }

        

        public LinkedList(T data) // перегруженный конструктор (когда сразу хотим что-то добавить)
        {
            var item = new Item<T>(data);
            SetFirstAndLast(data);

        }

        public void Add(T data) //Добавление элемента в список
        {
           

            if (Last != null)
            {
                var item = new Item<T>(data);
                Last.Next = item;
                Last = item;
                Count++;
            }
            else
            {
                SetFirstAndLast(data);
            }
        }


        public void Remove(T data)  // удаление элемента из списка
        {
            if (First != null) 
            {
                if (First.Data.Equals(data)) 
                {
                    First = First.Next;
                    Count--;
                    return;
                }

                var current = First.Next;
                var previous = First;


                while (current != null) 
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetFirstAndLast(data);
            }
        }


        public void Clear() // удаление всех узлов из списка
        {
            First = null;
            Last = null;
            Count = 0;
            
        }


        public void AddFirst(T data) // поместить в голову
        {
            var item = new Item<T>(data);
            item.Next = First;
            First = item;
            Count++;
        }


        public void AddAfter(T target, T data) // вставляем данные после определённого значения
        {
            
            if (First != null)
            {
                
                var current = First;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else // для себя решить если список пустой либо не добавляем ничего либо вставить данные
            {
                //SetFirstAndLast(target);
                //Add(data);
            }
        }







         
        private void SetFirstAndLast(T data) 
        {
            var item = new Item<T>(data);
            First = item;
            Last = item;
            Count = 1;
        }




        

        public IEnumerator GetEnumerator()
        {
            var current = First;
            while (current != null) 
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + " элементов";
        }
    }



}
