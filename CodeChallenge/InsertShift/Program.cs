using System;
using System.Collections.Generic;
using System.Linq;


namespace InsertShift
{



    public class Program
    {
        public static List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = synonyms.Keys.Select(key =>
            {
                string synonymValue = synonyms[key];
                string antonymValue = antonyms.TryGetValue(key, out string value) ? value : null;
                return new List<string> { key, synonymValue, antonymValue };
            }).ToList();

            return result;
        }


        static void Main(string[] args)
        {
         
            Dictionary<string, string> synonymsHashTable = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

            Dictionary<string, string> antonymsHashTable = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

           
            List<List<string>> result = LeftJoin(synonymsHashTable, antonymsHashTable);

            
            Console.WriteLine("The Result:");
            foreach (var row in result)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }

            //Hashtable hashtable = new Hashtable();

            //hashtable.Set("name", "Bashar");
            //hashtable.Set("age", 23);
            //hashtable.Set("city", "Amman");

            //Console.WriteLine("Name: " + hashtable.Get("name"));
            //Console.WriteLine("Age: " + hashtable.Get("age"));
            //Console.WriteLine("Has city: " + hashtable.Has("city"));
            //Console.WriteLine("Has country: " + hashtable.Has("country"));

            //List<string> keys = hashtable.Keys();
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