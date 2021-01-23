using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//gecici dizinin referansı = itemin referansi sonra da;
            items = new T[items.Length+1]; //eleman sayisini arttirdim
            for (int i = 0; i < tempArray.Length; i++)//eski elemanlara yeniden kavusmak icin bunu yaptik
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
