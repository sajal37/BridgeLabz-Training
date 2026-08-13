using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Implement_a_Custom_Hash_Map
    {
        public static void Main(string[] args)
        {
            MyHashMap map1 = new MyHashMap(10);
            map1.Insert("name", "Sajal");
            map1.Insert("city", "Delhi");
            map1.Insert("age", "22");
            Console.WriteLine("name: " + map1.Get("name"));
            Console.WriteLine("city: " + map1.Get("city"));
            map1.Delete("city");
            Console.WriteLine("city after delete: " + map1.Get("city"));
            map1.Insert("name", "Rahul");
            Console.Write("name after update: " + map1.Get("name"));
        }
    }
    class HashNode
    {
        public string key;
        public string value;
        public HashNode next;
        public HashNode (string key, string value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
    class MyHashMap
    {
        private HashNode[] buckets;
        private int size;
        public MyHashMap (int size)
        {
            this.size = size;
            this.buckets = new HashNode[size];
        }
        int GetHash(string key)
        {
            int hash = 0;
            foreach (char c in key) hash += c;
            return hash % size;
        }
        public void Insert(string key, string value)
        {
            int idx = GetHash(key);
            HashNode curr = buckets[idx];
            while (curr != null)
            {
                if (curr.key == key)
                {
                    curr.value = value;
                    return;
                }
                curr = curr.next;
            }
            HashNode newNode = new HashNode(key, value);
            newNode.next = buckets[idx];
            buckets[idx] = newNode;
        }
        public string Get(string key)
        {
            int idx = GetHash(key);
            HashNode curr = buckets[idx];
            while (curr != null)
            {
                if (curr.key == key) return curr.value;
                curr = curr.next;
            }
            return "Not Found";
        }
        public void Delete(string key)
        {
            int idx = GetHash(key);
            if (buckets[idx] == null) return;
            if (buckets[idx].key == key)
            {
                buckets[idx] = buckets[idx].next;
                return;
            }
            HashNode curr = buckets[idx];
            while (curr.next != null && curr.next.key != key)
                curr = curr.next;
            if (curr.next != null)
                curr.next = curr.next.next;
        }
    }
}
