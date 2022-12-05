using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        HashSet<T> set;
        public int Size => set.Count;

        public List<T> Elements { get; set; }

        public static ISet<int> Intersection(ISet<int> set1, ISet<int> set2)
        {
            throw new NotImplementedException();
        }

        public static ISet<int> Union(ISet<int> set1, ISet<int> set2)
        {
            
            throw new NotSupportedException();
        }

        public void Add(ISet<T> s)
        {
            foreach (var thing in s)
            {
                set.Add(thing);
            }
        }

        public void Add(T value)
        {
            set.Add(value);
        }

        public bool Contains(T value)
        {
            if (set.Contains(value) == true)
            {
                return true;
            }
            else
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(ISet<T> s)
        {
            foreach (var thing in s) 
            {
                set.Remove(thing);
                    
            }

        }

        public void Remove(T value)
        {
            set.Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
