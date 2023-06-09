using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>
            {
                { "K1", "V1" },
                { "K2", "V2" },
                { "K3", "V3" }
            };

            Dictionary<string, string> dict2 = new Dictionary<string, string>
            {
                { "K1", "V11" },
                { "K2", "V2" },
                { "K4", "V4" }
            };

            // Compare dictionaries
            CompareDictionaries(dict1, dict2);

            Console.ReadLine();
        }

        static void CompareDictionaries<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
        {
            Console.WriteLine("Key-Value pairs present in the first dictionary but not in the second:");
            foreach (var kvp in dict1)
            {
                if (!dict2.ContainsKey(kvp.Key))
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }

            Console.WriteLine("Key-Value pairs present in the second dictionary but not in the first:");
            foreach (var kvp in dict2)
            {
                if (!dict1.ContainsKey(kvp.Key))
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }

            Console.WriteLine("Key-Value pairs with different values:");
            foreach (var kvp in dict1)
            {
                if (dict2.TryGetValue(kvp.Key, out var value) && !kvp.Value.Equals(value))
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value in Dict1: {kvp.Value}, Value in Dict2: {value}");
                }
            }
        }
    }
}