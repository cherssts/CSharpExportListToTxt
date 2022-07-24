using System;
using System.Linq;
using System.IO;
using System.Threading;
using System.Data;



namespace Program1111
{
    public class Program1
    {
        static void Main(string[] args)
        {
            
            string _arrString = "Write Your Stuff";
            char Sperator = ';';
            //Console.WriteLine(_arrString.Count());
            string[] Separated = _arrString.Split(Sperator);

            //string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
            //string stringBeforeChar = authors.Substring(0, authors.IndexOf(","));
            //Console.WriteLine(stringBeforeChar);

            //string stringAfterChar = authors.Substring(authors.IndexOf(",") + 2);
            //Console.WriteLine(stringAfterChar);
            List<string> _stringList = new List<string>();
            for (int i = 0; i < Separated.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Server= " + Separated[i] + ';');
                        _stringList.Add("Server= " + Separated[i] + ';');
                        break;
                    case 1:
                        Console.WriteLine("Port= " + Separated[i] + ';');
                        _stringList.Add("Port = " + Separated[i] + ';');
                        break;
                    case 2:
                        Console.WriteLine("UserID= " + Separated[i] + ';');
                        _stringList.Add("UserID= " + Separated[i] + ';');
                        break;
                    case 3:
                        Console.WriteLine("Password= " + Separated[i] + ';');
                        _stringList.Add("Password= " + Separated[i] + ';');
                        break;
                    case 4:
                        Console.WriteLine("Database = " + Separated[i] + ';');
                        _stringList.Add("Database = " + Separated[i] + ';');
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in _stringList)
            {
                Console.WriteLine(item.Substring(item.IndexOf("=") + 2));
            }
            Console.ReadLine();
        }
    }
}