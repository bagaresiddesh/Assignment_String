using System;
using System.Text;

namespace StringBuilderFunctions
{
    public class SBFunctions
    {
        public void Append(StringBuilder str)
        {
            Console.WriteLine("Append : {0}", str.Append("Hello"));
        }

        public void AppendFormat(StringBuilder str)
        {
            Console.WriteLine("AppendFormat : {0}", str.AppendFormat("Hello"));
        }

        public void Insert(StringBuilder str)
        {
            Console.WriteLine("Insert : {0}", str.Insert(5,"Hello"));
        }

        public void Remove(StringBuilder str)
        {
            Console.WriteLine("Remove : {0}", str.Remove(5, 3)); 
        }

        public void Replace(StringBuilder str)
        {
            Console.WriteLine("Replace : {0}", str.Replace("siddeHello","bye" ));
        }
    }
}
