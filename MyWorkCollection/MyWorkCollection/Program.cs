using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of Random   
            Random random = new Random();
            var v = random.Next(0, 5);

            Console.WriteLine("Random Number is");
            Console.WriteLine(v);

            //Declaration of String Array  
            string[] ObjArray = new string[5];
            ObjArray[0] = "Roopa";
            ObjArray[1] = "Jamadar";
            ObjArray[2] = "ABC";
            ObjArray[3] = "XYZ";
            ObjArray[4] = "DEF";

            //Declaration of Int Array  
            int[] objInt = new int[5];
            objInt[0] = 100;
            objInt[1] = 200;
            objInt[2] = 300;
            objInt[3] = 400;
            objInt[4] = 500;

            //Creation of array list  
            ArrayList ObjArraylist = new ArrayList();
            ObjArraylist.Add("Jamadar");
            ObjArraylist.Add(123);

            //Creation of Dictionary  

            Dictionary<string, long> myDictionary = new Dictionary<string, long>();
            myDictionary.Add("Roopa", 415434543);
            myDictionary["ABC"] = 415984588;
           

            //Creation of Hashtable  
            Hashtable ht = new Hashtable();
            ht.Add("India", "1");
            ht.Add("Bangalore", "0");


            //Output of Int Array  
            Console.WriteLine("Intiger array Output is");
            Console.WriteLine(objInt[v]);

            //Output of string Array  
            Console.WriteLine("String array Output is");
            Console.WriteLine(ObjArray[v]);

            //Output of Int Array list  
            Console.WriteLine("Arraylist Output is");

            Console.WriteLine(ObjArraylist[v]);

            //Output of Dictionary  

            Console.WriteLine("Dictionary Output is");
            foreach (KeyValuePair<string,long> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();

        }
    }
}
