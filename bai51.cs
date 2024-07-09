//51a
using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            Console.WriteLine(i);
        }
    }
}


//51b
using System;
using System.Collections.Generic;

namespace Dict1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[3] = "Nam";
            dict1[8] = "Lan";
            
            foreach (KeyValuePair<int, string> item in dict1)
            {
                Console.WriteLine(item.Key.ToString() + ":" + item.Value);
            }
        }
    }
}


//51c
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[3] = "Nam";
            dict1[8] = "Lan";
            
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key.ToString() + ":" + item.Value);
            }
        }
    }
}


//51d
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[3] = "Nam";
            dict1[8] = "Lan";
            dict1.Add(7, "Mai");
            
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key.ToString() + ":" + item.Value);
            }
        }
    }
}


//51e
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[3] = "Nam";
            dict1[8] = "Lan";
            dict1.Add(7, "Mai");
            
            foreach (var key in dict1.Keys)
            {
                Console.WriteLine(key.ToString());
            }
        }
    }
}


//51g
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[3] = "Nam";
            dict1[8] = "Lan";
            dict1.Add(7, "Mai");
            
            foreach (var val in dict1.Values)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
