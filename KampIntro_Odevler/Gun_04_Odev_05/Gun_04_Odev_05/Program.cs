using System;
using System.Collections.Generic;

namespace Gun_04_Odev_05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "bir");
            myDictionary.Add(2, "iki");
            myDictionary.Add(3, "üç");
            myDictionary.Add(4, "dört");
            myDictionary.Add(5, "beş");
            myDictionary.Add(6, "altı");
            myDictionary.Add(7, "yedi");
            myDictionary.Add(8, "sekiz");
            myDictionary.Add(9, "dokuz");

            myDictionary.Key(6);
        }
    }
}


class MyDictionary<TKey, TValue>
{
    List<TKey> _keys;
    List<TValue> _values;
    public MyDictionary()
    {
        _keys = new List<TKey>();
        _values = new List<TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        _keys.Add(key);
        _values.Add(value);
    }

    public void Key(TKey key)
    {
        Console.WriteLine(_values[_keys.IndexOf(key)]);
    }

}
