namespace Hashtable;

class Program
{
    static void Main(string[] args)
    {
        ///<summary>
        ///UC1:Find the frequency of word in sentence
        /// </summary>
        Console.WriteLine("Welcome to Data Structure Problem Using Generics");
        LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);  ///Creating Linklist Hashmap 
        string sentence = "to be or not to be";                                        
        string[] words = sentence.ToLower().Split(" ");                                /// Created the array and Splitting The Sentances, 
        foreach (string word in words)                                                 ///To Take Every Word In That Sentaces
        {
            int value = LinkedHashMap.Get(word);                                      
            if (value == default)                                                      // Storing Value as 1
            {
                value = 1;
            }
            else value += 1;                                                           ///We get a identity but not intialize the linked list
            LinkedHashMap.Add(word, value);                                            // At last it will come here and Second word will executed
        }
        int frequency = LinkedHashMap.Get("to");
        Console.WriteLine(frequency);
    }
}
