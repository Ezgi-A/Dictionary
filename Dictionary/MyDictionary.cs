using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T, T1>
    {

        T[] userid;
        T1[] username;
        T[] temp1;
        T1[] temp2;

        public MyDictionary()
        {
            
            userid = new T[0];
            username = new T1[0];
        }
        public void Add(T userId, T1 userName)
        {

          

            temp1 = userid;
            temp2 = username;

            userid = new T[userid.Length + 1];
            username = new T1[username.Length + 1];

            for (int i = 0; i < temp1.Length; i++)
            {
                userid[i] = temp1[i];


            }
            for (int i = 0; i < temp2.Length; i++)
            {
                username[i] = temp2[i];
            }


            userid[userid.Length - 1] = userId;
            username[username.Length - 1] = userName;


        }
        public int Count
        {
            get { return userid.Length; }


        }
        public T1 this[T key]
        {
            get
            {
                int index = Array.IndexOf(userid, key);
                return username[index];
            }
        }
        
    }
    }
