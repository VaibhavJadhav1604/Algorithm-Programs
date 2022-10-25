using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace BinarySearch
{
    internal class BS
    {
        public string[] words;
        static void Main(string[] args)
        {
            BS ob=new BS();
            //reading contents of file line by line
            string[] lines = File.ReadAllLines(@"D:\BridgeLabz\main.txt");
            foreach (string line in lines)
            {
                //splitting the words of lines by comma(,)
                ob.words = line.Split(",");
            }
            Console.Write("Enter Word:");
            string val=Console.ReadLine();
            foreach(string word in ob.words)
            {
                //comparing user value with words in file
                if(word==val)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
                else
                {
                    Console.WriteLine("Value Not Found");
                    break;
                }
            }
        }
    }
}
