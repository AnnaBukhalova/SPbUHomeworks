﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList

    // Создаём элемент класса

{
    public class Item<T> 
    {
        private T data = default(T);

        public T Data
        {
            get => data;
            set 
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
            
            
        }



        public Item<T> Next { get; set; }



        public Item(T data)
       {
            this.Data = data;
       }

        public override string ToString()
        {
            return Data.ToString();
        }

       
    }
}
