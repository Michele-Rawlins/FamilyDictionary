using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { {"name" ,"Rachel" }, {"age", "34" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Lois" }, { "age", "77" } });
            myFamily.Add("oldest-brother", new Dictionary<string, string>() { { "name", "Chuck" }, { "age", "49" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Russell" }, { "age", "41" } });
            myFamily.Add("youngest-brother", new Dictionary<string, string>() { { "name", "Nathan" }, { "age", "36" } });
            //myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Jeremy" }, { "age", "38" } });
          


            foreach (var familyMember in myFamily )
            {
                            
                    Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
               
            }
        }
    }
}
