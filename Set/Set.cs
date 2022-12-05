using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> set;
        //forgot to make a public set
        public Set()
        {
            set = new HashSet<T>();
        }
        public int Size => set.Count;


        // get set did not work for elements :(
        // create a list of elements to pull from
        public List<T> Elements
        {
            get
            {
                List<T> list = new List<T>();
                foreach (var item in set)
                {
                    list.Add(item);
                }
                return list;
            }
        }

        public static ISet<int> Intersection(ISet<int> set1, ISet<int> set2)
        {
            Set<int> newSet = new Set<int>();
            // for each element in a set if they match add them to a new set
            foreach (var element1 in set1)
            {
                foreach (var element2 in set2)
                {
                    if (element1.Equals(element2))
                    {
                        newSet.Add(element1);
                    }
                }
            }
            return newSet;
        }

        public static ISet<int> Union(ISet<int> set1, ISet<int> set2)
        {
            // add all elements to a set
            Set<int> newSet = new Set<int>();
            foreach (var element1 in set1)
            {
                newSet.Add(element1);
            }
            foreach (var element2 in set2)
            {
                newSet.Add(element2);
            }
            return newSet;
        }
        // basic functions
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
            return set.GetEnumerator();
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
            return set.GetEnumerator();
        }
    }
}
