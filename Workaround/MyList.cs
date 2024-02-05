using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
public class MyList<T>:IEnumerable<T>
{
   private T[] _list;

    public MyList() => _list = new T[0];

    public void Add(T item)
    {
       T[] tempList =  new T[_list.Length+1];

       
        for (int i = 0; i < _list.Length; i++)
        {
            tempList[i] = _list[i];
        }

        tempList[_list.Length] = item;


        _list = tempList;
    }
    public int Counter
    {
        get { return _list.Length;}
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_list).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _list.GetEnumerator();
    }
}