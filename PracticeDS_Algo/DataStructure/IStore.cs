using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    interface IStore<T>
    {
        void Insert(T item);
        void Remove(T item);
        int Find(T item);
    }
}
