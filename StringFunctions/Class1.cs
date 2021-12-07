using System;

namespace StringFunctions
{
    public class StrFunctions
    {
        public void Clone(string str)
        {
            Console.WriteLine("Clone {0}: ", str.Clone());
        }

        public void Compare(string str1, string str2)
        {
            Console.WriteLine("Compare : {0}", string.Compare(str2, str1));
        }

        public void CompareOrdinal(string str1, string str2)
        {
            Console.WriteLine("CompareOrdinal : {0}", string.CompareOrdinal(str2, 3, str1, 1, 3));
        }

        public void CompareTo(string str1, string str2)
        {
            Console.WriteLine("CompareTo : {0}", str1.CompareTo(str2));
        }

        public void Concat(string str1, string str2)
        {
            Console.WriteLine("Concat : {0}", string.Concat(str1, str2));
        }

        public void Contains(string str1, string str2)
        {
            Console.WriteLine("Contains : {0}", str1.Contains(str1));
        }

        public void Copy(string str1)
        {
            string str = string.Copy(str1);
            Console.WriteLine("Copied string : {0}", str);
        }

        public void CopyTo(string str1)
        {
            char[] dest = new char[15];
            str1.CopyTo(3, dest, 0, 3);
            Console.WriteLine("Copied string : {0}", dest);
        }

        public void EndsWith(string str1, string str2)
        {
            Console.WriteLine("Endswith : {0}", str1.EndsWith(str2));
        }

        public void Equals(string str1, string str2)
        {
            Console.WriteLine("Equals : {0}", str1.Equals(str2));
        }

        public void Format(DateTime str)
        {
            Console.WriteLine("Before Format : {0}", str);
            string str1 = string.Format("{0:D}", str);
            Console.WriteLine("After Format : {0}", str1);
        }

        public void Enumarator(string str)
        {
            CharEnumerator ch = str.GetEnumerator();
            Console.WriteLine("Enumarator : ");

            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
        }

        public void GetTypeHash(string str)
        {
            Type t = str.GetType();
            TypeCode code = Type.GetTypeCode(t);
            Console.WriteLine("Type is :{0}", t);
            Console.WriteLine("Type Code is :{0}", code);
            Console.WriteLine("Hash Code is :{0}",t.GetHashCode());
        }

        public void IndexOf(string str)
        {
            int index2 = str.IndexOf('e');
            Console.WriteLine("Index of 'e' is {0}",index2);
        }

        public void Insert(string str)
        {
            Console.WriteLine("Inserted : {0}", str.Insert(4,"SB"));
        }

        public void Intern(string str)
        {
            string str1 = string.Intern(str);
            string str2 = string.IsInterned(str);

            Console.WriteLine("Intern : {0}", str1);
            Console.WriteLine("IsInterned : {0}", str2);
        }

        public void IsNormalized(string str)
        {
            Console.WriteLine("IsNormalized : {0}", str.IsNormalized());
        }

        public void IsNullOrEmpty(string str)
        {
            Console.WriteLine("IsNullOrEmpty : {0}", string.IsNullOrEmpty(str));
        }

        public void IsNullOrWhiteSpace(string str)
        {
            Console.WriteLine("IsNullOrWhiteSpace : {0}", string.IsNullOrWhiteSpace(str));
        }

        public void Join()
        {
            object[] array = { "Hello", "World", 12345 };
            string str1 = string.Join(". ", array);

            Console.WriteLine("Value of string {0} ", str1);
        }

        public void LastIndexOf(string str)
        {
            int index = str.LastIndexOf('a');
            Console.WriteLine("Index : {0} ", index);
        }

        public void LastIndexOfAny(string str)
        {
            int index = str.LastIndexOf('a');
            Console.WriteLine("Index of any : {0} ", index);
        }

        public void Normalize(string str)
        {
            Console.WriteLine("Normalize : {0} ", str.Normalize());
        }

        public void Pad(string str)
        {
            Console.WriteLine("Pad Left : {0} ", str.PadLeft(15));
            Console.WriteLine("Pad Right : {0} ", str.PadRight(13));
        }

        public void Remove(string str)
        {
            Console.WriteLine("Remove : {0} ", str.Remove(3));
        }

        public void Replace(string str)
        {
            Console.WriteLine("Replaced : {0} ", str.Replace('e','z'));
        }

        public void SplitWhiteSpace()
        {
            string str1 = "Hello C Sharp";
            string[] str2 = str1.Split(' ');
            Console.WriteLine("Split using whitespace : ");
            foreach (string str3 in str2)
            {
                Console.WriteLine(str3);
            }
        }

        public void SplitComma()
        {
            string str1 = "Hello,C,Sharp";
            string[] str2 = str1.Split(',');
            Console.WriteLine("Split using comma : ");
            foreach (string str3 in str2)
            {
                Console.WriteLine(str3);
            }
        }

        public void SplitUsingChar()
        {
            string str1 = "Hello@Sharp@com";
            string[] str2 = str1.Split('@');
            Console.WriteLine("Split using '@' : ");
            foreach (string str3 in str2)
            {
                Console.WriteLine(str3);
            }
        }

        public void StartsWith(string str)
        {
            Console.WriteLine("StartsWith : {0} ", str.StartsWith("S"));
        }

        public void Substring(string str)
        {
            Console.WriteLine("Substring : {0} ", str.Substring(3));
        }
        
        public void ToCharArray(string str)
        {
            char[] chars = str.ToCharArray();

            Console.WriteLine("String: " + str);
            Console.Write("Character array :");

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(" " + chars[i]);
            }                
        }

        public void ToLower(string str)
        {
            Console.WriteLine("ToLower : {0} ", str.ToLower());
        }

        public void ToLowerInvariant(string str)
        {
            Console.WriteLine("ToLowerInvariant : {0} \t", str.ToLower());
            Console.Write("Original String  : {0} ", str);
        }

        public void ToString(int num)
        {
            Console.WriteLine("ToString : {0} ", num.ToString());
        }

        public void ToUpper(string str)
        {
            Console.WriteLine("ToUpper : {0} ", str.ToUpper());
        }

        public void Trim(string str)
        {
            Console.WriteLine("Trim : {0} ", str.Trim());
        }

        public void TrimStart()
        {
            string str1 = "000abc000";
            Console.WriteLine("Before TrimStart : {0}",str1);
            Console.WriteLine("After : {0}", str1.TrimStart('0'));
        }

        public void TrimEnd()
        {
            string str1 = "000abc000";
            Console.WriteLine("Before TrimEnd : {0}", str1);
            Console.WriteLine("After : {0}", str1.TrimEnd('0'));
        }
    }
}
