using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    public static class ExportListToTextFile
    {

        static void Main(string[] args)
        {
            var data = new Person[] {
            new Person() { ID = 1, FirstName = "John", Surname = "Smith" },
            new Person() { ID = 2, FirstName = "Max", Surname = "McDonald" }
            };
            data.ExportToTextFile("person.txt", ';');
        }

        static void ExportToTextFile<T>(this IEnumerable<T> data, string FileName, char ColumnSeperator)
        {
            using (var sw = File.CreateText(FileName))
            {
                var plist = typeof(T).GetProperties().Where(p => p.CanRead && (p.PropertyType.IsValueType || p.PropertyType == typeof(string)) && p.GetIndexParameters().Length == 0).ToList();
                if (plist.Count > 0)
                {
                    var seperator = ColumnSeperator.ToString();
                    sw.WriteLine(string.Join(seperator, plist.Select(p => p.Name)));
                    foreach (var item in data)
                    {
                        var values = new List<object>();
                        foreach (var p in plist) values.Add(p.GetValue(item, null));
                        sw.WriteLine(string.Join(seperator, values));
                    }
                }
            }
        }

    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
