using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {
        public static Node newNode(int ele)
        {
            Node temp = new Node();
            temp.key = ele;
            temp.left = null;
            temp.right = null;
            return temp;
        }
        public static Node insert(Node node, int key)
        {
            if (node == null)
            {
                return newNode(key);
            }

            if (key < node.key)
            {
                node.left = insert(node.left, key);
            }
            else if (key > node.key)
            {
                node.right = insert(node.right, key);
            }

            return node;
        }

        public static string RepeatedWord(string text)
        {

            string[] words = text.Split(new char[] { ' ', '.', ',', ';','#', '!', '$','?',':' }, StringSplitOptions.RemoveEmptyEntries);

            Hashtable duplicateWord = new Hashtable();

            foreach (string word in words)
            {
                string clearString = word.ToLower();
                if (duplicateWord.Has(clearString))
                {
                    return clearString;
                }
                else
                {
                    duplicateWord.Set(clearString, true);
                }
            }

            return null;
        }



        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Set("name", "Bashar");
            hashtable.Set("age", 23);
            hashtable.Set("city", "Amman");

            Node tree1 = null;
            tree1 = insert(tree1, 2);
            tree1 = insert(tree1, 11);
            tree1 = insert(tree1, 290);
            tree1 = insert(tree1, 0);
            tree1 = insert(tree1, 4);
            tree1 = insert(tree1, 8);
            tree1 = insert(tree1, 9);

            Node tree2 = null;
            tree2 = insert(tree2, 10);
            tree2 = insert(tree2, 7);
            tree2 = insert(tree2, 20);
            tree2 = insert(tree2, 4);
            tree2 = insert(tree2, 11);
            tree2 = insert(tree2, 8);

            List<int> sharedNodes = TreeIntersection.FindIntersection(tree1 , tree2);


            Console.WriteLine("The Intersection Element in Tree Is:");
            foreach (int value in sharedNodes)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            //Console.WriteLine("Name: " + hashtable.Get("name"));
            // Console.WriteLine("Age: " + hashtable.Get("age"));
            // Console.WriteLine("Has city: " + hashtable.Has("city"));
            // Console.WriteLine("Has country: " + hashtable.Has("country"));

            string text = "Once , , upon a time, there was a brave princess who...";
            string repeatedWord =RepeatedWord(text);
            Console.WriteLine("First repeated word: " + repeatedWord);


           // List<string> keys = hashtable.Keys();
           //Console.WriteLine("Keys: " + string.Join(", ", keys));
        }

    }

    public class KeyValue
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }

    public class Hashtable
    {
        public const int Size = 100;
        public List<List<KeyValue>> table;

        public Hashtable()
        {
            table = new List<List<KeyValue>>(Size);
            for (int i = 0; i < Size; i++)
            {
                table.Add(new List<KeyValue>());
            }
        }

        public int CalculateHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash += c;
            }
            return hash % Size;
        }

        public void Set(string key, object value)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    kvp.Value = value;
                    return;
                }
            }

            bucket.Add(new KeyValue { Key = key, Value = value });
        }

        public object Get(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return kvp.Value;
                }
            }

            return null;
        }

        public bool Has(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();

            foreach (var bucket in table)
            {
                foreach (var kvp in bucket)
                {
                    keys.Add(kvp.Key);
                }
            }

            return keys;
        }

     
    }



}
