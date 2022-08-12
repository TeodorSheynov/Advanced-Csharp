using System;
using System.Collections.Generic;
using System.Linq;

namespace dotNetCoreHomework
{
    public class Box
    {
        private List<int> _list;

        public Box()
        {
            _list=new List<int>();
        }

        public Box(List<int> collection)
        {
            _list=collection;
        }


        public void Add(int number)
        {
            _list.Add(number);
        }

        public List<int> Filter(Func<int,bool> predicate)
        {
            return _list.Where(predicate).ToList();
        }
    }
}