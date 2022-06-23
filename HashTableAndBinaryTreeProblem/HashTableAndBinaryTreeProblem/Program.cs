using DataStructure;
using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///UC1:Find the frequency of word in sentence
            /// </summary>
            Console.WriteLine("Welcome to Data Structure Problem Using Generics");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);  ///1 Creating Linklist Hashmap 
            string sentence = "to be or not to be";                                        ///2
            string[] words = sentence.ToLower().Split(" ");                                ///3 Created the array and Splitting The Sentances, 
            foreach (string word in words)                                                 ///4 To Take Every Word In That Sentaces
            {
                int value = LinkedHashMap.Get(word);                                       ///5 To determine its value We are getting in to 5.1
                if (value == default)                                                      //5.9 Storing Value as 1
                {
                    value = 1;
                }
                else value += 1;                                                           ///6 We get a identity but not intialize the linked list
                LinkedHashMap.Add(word, value);                                            //6.20 At last it will come here and Second word will executed
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(frequency);



        }
    }
}

//UC_1
//Ability to find frequency of words in a sentence like “To be or not to be”

//- Use LinkedList to do the Hash Table Operation
//- To do this we create MyMapNode with Key Value Pair and create LinkedList of MyMapNode

//Result
//Welcome to Data Structure Problem Using Generics
//2