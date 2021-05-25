/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 9:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace carList
{
    class Program
    {
        public static void WriteToFile(carList a, string fileName)
        {
            try
            {
                using (StreamWriter SW = new StreamWriter(fileName, false, Encoding.Default))
                {
                    SW.WriteLine(a.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static carList ReadFromFile(string fileName)
        {
            try
            {
                using (StreamReader SR = new StreamReader(fileName))
                {
                    carList list = new carList();
                    string res = SR.ReadToEnd();
                    string[] lres = new string[res.Split('\n').Length];
                    lres = res.Split('\n');
                    for (int i = 0;i < res.Split('\n').Length; ++i)
                    {
                        list.Addcar(new car(res.Split('\n')[i].Split(' ')));
                    }
                    
                    return list; 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static void BinaryWrite(carList lst, string fileName)
        {
            try
            {
                using (BinaryWriter BW = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
                {
                    BW.Write(lst.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static carList BinaryReader(string fileName)
        {
            try
            {
                using (BinaryReader BR = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (BR.PeekChar() > -1)
                    {
                        string lst = BR.ReadString();
                        carList list = new carList();
                        string[] lres = new string[lst.Split('\n').Length];
                        foreach (var v in lst.Split('\n'))
                        {
                            list.Addcar(new car(v.Split(' ')));
                        }

                        return list;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static void Main(string[] args)
        {
            carList list = new carList();
            list.Addcar(new car("AB2302HT", "26.12.1234", "31.12.2312", "0", "pink", 666));
            list.Addcar(new car("porshe2", "puk", "6666", "20.584", "20", 20));
            list.Addcar(new car("porshe3", "puk", "6666", "20.584", "20", 20));
            list.Addcar(new car("porshe4", "puk", "6666", "20.584", "20", 20));
            list.Addcar(new car("porshe5", "puk", "6666", "20.584", "20", 20));
            Console.WriteLine(list);
            car res = list.Findcar("porshe5");
            Console.WriteLine(res);

            carList resList = list.FindAllcar("6666");
            Console.WriteLine(resList);

            WriteToFile(list, @"C:\file.txt");
            Console.WriteLine("-----");
            //Console.WriteLine("Read: " + ReadFromFile(@"C:\file.txt"));
            /*
            BinaryWrite(list, @"C:\file.bin");
            Console.WriteLine("-----");
            Console.WriteLine("Bin: " + BinaryReader(@"C:\file.bin"));
            */
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}