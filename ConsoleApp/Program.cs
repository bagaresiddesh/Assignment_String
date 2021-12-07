using System;
using System.Text;
using StringFunctions;
using StringBuilderFunctions;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        { 
            Console.WriteLine("String functions : ");
            Console.WriteLine("");
        
            string firstname = "Siddesh";
            string lastname = "Bagare";
            string str1 = "abcdefg";
            string str2 = "cdefg";
            string str3 = null;//null string 
            int num = 1234;
            string name = "Siddesh Bagare";

            DateTime myDate = new DateTime(2021, 11, 22);

            StrFunctions obj= new StrFunctions();//object craetion of StringFunction

            obj.Clone(firstname);//Colne

            obj.Compare(firstname,lastname);//Compare
            obj.Compare(firstname, "siddesh");

            obj.CompareOrdinal(str1,str2);//CompareOrdinal

            obj.CompareTo(str1, str2);//CompareTo
            obj.CompareTo(firstname,lastname);

            obj.Concat(firstname, lastname);//Conctat

            obj.Contains(str1, str2);//Contains
            obj.Contains(str1, firstname);

            obj.Copy(firstname);//Copy

            obj.CopyTo("GeeksforGeeks");//CopyTo

            obj.EndsWith(str1, str2); //EndsWith
            obj.EndsWith(lastname, str2);

            obj.Equals(str1, str2);//Equals
            obj.Equals(str1, str1);

            obj.Format(myDate);//Format

            obj.Enumarator(firstname);//Enumarator

            obj.GetTypeHash(firstname);//GetType and GetHashCode and GetTypeCode

            obj.IndexOf(firstname);//IndexOf

            obj.Insert(firstname);//Insert

            obj.Intern(firstname);//Intern and IsInterned

            obj.IsNormalized(lastname);//Normalized

            obj.IsNullOrEmpty(lastname);//IsNullOrEmpty
            obj.IsNullOrEmpty(str3);

            obj.IsNullOrWhiteSpace(str3);//IsNullOrWhiteSpace
            obj.IsNullOrWhiteSpace(lastname);

            obj.Join();//Join

            obj.LastIndexOf(lastname);//LastIndexOf

            obj.LastIndexOfAny(lastname);//LastIndexOfAny

            obj.Normalize(firstname);//Normalized

            obj.Pad(firstname);//PadLeft and PadRight

            obj.Remove(firstname);//Remove

            obj.Replace(firstname);//Replace

            obj.SplitWhiteSpace();//SplitWhiteSpace

            obj.SplitComma();//SplitComma

            obj.SplitUsingChar();//SplitUsingChar

            obj.StartsWith(firstname);//StartsWith

            obj.Substring(firstname);//SubString

            obj.ToCharArray(lastname);//ToCharArray

            obj.ToLower(lastname);//ToLower

            obj.ToLowerInvariant(lastname);//ToLowerInvariant

            obj.ToString(num);//ToString

            obj.ToUpper(lastname);//ToUpper

            obj.Trim(name);//Trim

            obj.TrimStart();//TrimTrimStart

            obj.TrimEnd();//TrimEnd

            ///////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("");
            Console.WriteLine("StringBuilder functions : ");
            Console.WriteLine("");

            SBFunctions ob = new SBFunctions();//StringBuilder class object created 

            StringBuilder sb1 = new StringBuilder("Siddesh", 10);
            StringBuilder sb2 = new StringBuilder("Bagare", 10);

            ob.Append(sb1);//Append

            ob.AppendFormat(sb2);//AppendFormat

            ob.Insert(sb1);//Insert

            ob.Remove(sb2);//Remove

            ob.Replace(sb1);//Replace

            Console.ReadLine();
        }
    }
}
