using System;
using System.Collections.Generic;
using System.Text;
using Hashtable;

namespace Hashtable;

class Program
{
    static void Main(string[] args)
    {
        ///<summary
        ///UC1:Find the frequency of word in sentence
        /// </summary>
        Console.WriteLine("Welcome to Data Structure Problem Using Generics");
        LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);  //Creating Linklist Hashmap 
        string sentence = "to be or not to be";                                        
        string[] words = sentence.ToLower().Split(" ");                                // Created the array and Splitting The Sentances, 
        foreach (string word in words)                                                 // To Take Every Word In That Sentaces
        {
            int value = LinkedHashMap.Get(word);                                       // To determine its value
            if (value == default)                                                      // Storing Value as 1
            {
                value = 1;
            }
            else value += 1;                                                           //We get a identity but not intialize the linked list
            LinkedHashMap.Add(word, value);                                            // At last it will come here and Second word will executed
        }
        int frequency = LinkedHashMap.Get("to");
        Console.WriteLine(frequency);
        ///UC_2:Find the frequency of word in paragraph
        string Paragraph = "“Paranoids are not paranoid because they are " +
            "paranoid but because they keep putting themselves deliberately into" +
            " paranoid avoidable situations";
        string[] letters = Paragraph.ToLower().Split(" ");

        foreach (string word in letters)
        {
            int value = LinkedHashMap.Get(word);
            if (value == default)
            {
                value = 1;
            }
            else value += 1;
            LinkedHashMap.Add(word, value);
        }
        int frequency1 = LinkedHashMap.Get("paranoid");
        Console.WriteLine(frequency1);

        //UC_3:Remove particular word from the paragraph

        LinkedHashMap.Remove("avoidable");
        int frequency2 = LinkedHashMap.Get("avoidable");

        Console.WriteLine(frequency2);
    }
}


       

           
