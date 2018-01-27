using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of a Hashtable          

            //Instanciate a new Hashtable
            Hashtable hashtable = new Hashtable();
            Random random = new Random();

            //Loop to populate the Hashtable - Keys are i and values are random ints
            for (var i = 1; i < 1001; i++)
            {
                int rnd = random.Next(10000000, 20000000);
                hashtable.Add(i, rnd);
            }

            //Display each entry in the Hashtable
            foreach (DictionaryEntry dragon in hashtable)
            {
                Console.Write("{0} {1}\n", dragon.Key, dragon.Value);
            }

            //Example of removing Hashtable entry
            if (hashtable.ContainsKey(8))
            {
                hashtable.Remove(8);
            }

            //Example of getting Value of Hashtable item by its Key
            Console.Write("Key 1 has a value of " + hashtable[1] + "\n");
            Console.Write("Key 10 has a value of " + hashtable[10] + "\n");
            Console.Write("Key 100 has a value of " + hashtable[100] + "\n");
            Console.Write("Key 1000 has a value of " + hashtable[1000] + "\n");
        }
    }
}
