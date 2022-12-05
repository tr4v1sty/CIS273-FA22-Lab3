using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Set
{
    public class Set<T> : ISet<T>
    {
       
        public int Size { get; set; }

        public List<T> Elements { get; set; }

        public static ISet<int> Intersection(ISet<int> set1, ISet<int> set2)
        {
            throw new NotImplementedException();
        }

        public static ISet<int> Union(ISet<int> set1, ISet<int> set2)
        {
            throw new NotImplementedException();
        }

        public void Add(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            var curNode = Elements;
            while (curNode != null)
            {
                if (curNode.Equals(value))
                {
                    return true;
                }
                

            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
