using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace dotNetCoreHomework
{
    public class CustomCollection<T>:Collection<T>
    {
        public List<T> Randomize()
        {
            
            var rnd = new Random();
            var items = this.Items;
            var myRandomArray = items.OrderBy(x => rnd.Next()).ToList();
            return myRandomArray;
        }
    }
}